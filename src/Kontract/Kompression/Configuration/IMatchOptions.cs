﻿using System;
using Kontract.Kompression.Model;

namespace Kontract.Kompression.Configuration
{
    /// <summary>
    /// Provides functionality to the configure pattern match operations.
    /// </summary>
    public interface IMatchOptions
    {
        /// <summary>
        /// Sets the usage of the default match finder and allows setting its limitations.
        /// </summary>
        IMatchLimitations FindMatchesWithDefault();

        /// <summary>
        /// Sets the factory to create an instance of <see cref="IPriceCalculator"/>.
        /// </summary>
        /// <param name="priceCalculatorFactory">The factory to create an instance of <see cref="IPriceCalculator"/>.</param>
        /// <returns>The option object.</returns>
        IMatchOptions CalculatePricesWith(Func<IPriceCalculator> priceCalculatorFactory);

        /// <summary>
        /// Sets the factory to add an <see cref="IMatchFinder"/>.
        /// </summary>
        /// <param name="matchFinderFactory">The factory to add an <see cref="IMatchFinder"/>.</param>
        /// <returns>The option object.</returns>
        IMatchLimitations FindMatchesWith(Func<FindLimitations, FindOptions, IMatchFinder> matchFinderFactory);

        /// <summary>
        /// Sets the factory to create an instance of <see cref="IMatchParser"/>.
        /// </summary>
        /// <param name="matchParserFactory">The factory to create an instance of <see cref="IMatchParser"/>.</param>
        /// <returns>The option object.</returns>
        IMatchOptions ParseMatchesWith(Func<FindOptions, IPriceCalculator, IMatchFinder[], IMatchParser> matchParserFactory);

        /// <summary>
        /// Sets whether to search matches from the end to the beginning of the data.
        /// </summary>
        /// <returns>The option object.</returns>
        IMatchOptions FindInBackwardOrder();

        /// <summary>
        /// Sets the size of a buffer located before the first position to search from.
        /// </summary>
        /// <param name="size">The buffer size.</param>
        /// <returns>The option object.</returns>
        IMatchOptions WithPreBufferSize(int size);

        /// <summary>
        /// Sets the amount of units to skip after a match.
        /// </summary>
        /// <param name="skip">The amount of units to skip after a match.</param>
        /// <returns>The option object.</returns>
        IMatchOptions SkipUnitsAfterMatch(int skip);

        /// <summary>
        /// Sets the number of tasks to use to find pattern matches.
        /// </summary>
        /// <param name="count">The number of tasks.</param>
        /// <returns>The option objects.</returns>
        IMatchOptions ProcessWithTasks(int count);

        /// <summary>
        /// Sets the size of a unit to match.
        /// </summary>
        /// <param name="unitSize">The size of a unit to match.</param>
        /// <returns>The option object.</returns>
        IMatchOptions WithUnitSize(UnitSize unitSize);
    }
}
