﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartialFill1.  ISO2002 ID# _ApW7idokEeC60axPepSq7g_-431538170.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
public partial record PartialFill1
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument to be ordered.
    /// </summary>
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    public required Price4 DealPrice { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate4Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    public MarketIdentification13? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Quantity of financial instrument ordered.
    /// </summary>
    public required QuantityOrAmount1Choice_ OriginalOrderedQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument that has been previously executed.
    /// </summary>
    public required QuantityOrAmount1Choice_ PreviouslyExecutedQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument that is remaining in order.
    /// </summary>
    public required QuantityOrAmount1Choice_ RemainingQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment.
    /// </summary>
    public QuantityOrAmount1Choice_? MatchIncrementQuantity { get; init; } 
    
    #nullable disable
}
