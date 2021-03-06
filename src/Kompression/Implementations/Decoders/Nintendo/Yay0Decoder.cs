﻿using System.IO;
using System.Linq;
using Komponent.IO;
using Kompression.Exceptions;
using Kompression.Extensions;
using Kompression.IO;
using Kontract.Kompression.Configuration;
using Kontract.Models.IO;

namespace Kompression.Implementations.Decoders.Nintendo
{
    public class Yay0Decoder : IDecoder
    {
        private readonly ByteOrder _byteOrder;

        public Yay0Decoder(ByteOrder byteOrder)
        {
            _byteOrder = byteOrder;
        }

        public void Decode(Stream input, Stream output)
        {
            var inputStartPosition = input.Position;

            var buffer = new byte[4];
            input.Read(buffer, 0, 4);
            if (!buffer.SequenceEqual(new byte[] { 0x59, 0x61, 0x79, 0x30 }))
                throw new InvalidCompressionException("Yay0" + (_byteOrder == ByteOrder.LittleEndian ? "LE" : "BE"));

            input.Read(buffer, 0, 4);
            var uncompressedLength = _byteOrder == ByteOrder.LittleEndian ? buffer.GetInt32LittleEndian(0) : buffer.GetInt32BigEndian(0);
            input.Read(buffer, 0, 4);
            var compressedTableOffset = _byteOrder == ByteOrder.LittleEndian ? buffer.GetInt32LittleEndian(0) : buffer.GetInt32BigEndian(0);
            input.Read(buffer, 0, 4);
            var uncompressedTableOffset = _byteOrder == ByteOrder.LittleEndian ? buffer.GetInt32LittleEndian(0) : buffer.GetInt32BigEndian(0);

            var circularBuffer = new CircularBuffer(0x1000);
            var compressedTablePosition = 0;
            var uncompressedTablePosition = 0;

            var bitLayout = new byte[compressedTableOffset - 0x10];
            input.Read(bitLayout, 0, bitLayout.Length);
            using (var bitReader = new BitReader(new MemoryStream(bitLayout), BitOrder.MostSignificantBitFirst, 1, ByteOrder.BigEndian))
            {
                while (output.Length < uncompressedLength)
                {
                    if (bitReader.ReadBit() == 1)
                    {
                        // Flag for uncompressed byte
                        input.Position = inputStartPosition + uncompressedTableOffset + uncompressedTablePosition++;
                        var value = (byte)input.ReadByte();

                        output.WriteByte(value);
                        circularBuffer.WriteByte(value);
                    }
                    else
                    {
                        // Flag for compressed data
                        input.Position = inputStartPosition + compressedTableOffset + compressedTablePosition;
                        var firstByte = input.ReadByte();
                        var secondByte = input.ReadByte();
                        compressedTablePosition += 2;

                        var length = firstByte >> 4;
                        if (length > 0)
                            length += 2;
                        else
                        {
                            // Yes, we do read the length from the uncompressed data stream
                            input.Position = inputStartPosition + uncompressedTableOffset + uncompressedTablePosition++;
                            length = input.ReadByte() + 0x12;
                        }
                        var displacement = (((firstByte & 0xF) << 8) | secondByte) + 1;

                        circularBuffer.Copy(output, displacement, length);
                    }
                }
            }
        }

        public void Dispose()
        {
            // Nothing to dispose
        }
    }
}
