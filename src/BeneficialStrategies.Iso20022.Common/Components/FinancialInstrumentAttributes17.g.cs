﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes17.  ISO2002 ID# _0Zq7QeEMEd-qUMZtd_eZuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
public partial record FinancialInstrumentAttributes17
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification14 SecurityIdentification { get; init; } 
    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    public IsoDecimalNumber? Quantity { get; init; } 
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    public IRenounceableEntitlementStatusTypeFormat1Choice? RenounceableEntitlementStatusType { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public IFractionDispositionType9Choice? FractionDisposition { get; init; } 
    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; } 
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    public AmountPrice2? MarketPrice { get; init; } 
    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    public required IDateFormat16Choice ExpiryDate { get; init; } 
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    public required IDateFormat16Choice PostingDate { get; init; } 
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    public Period4? TradingPeriod { get; init; } 
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    public IBalanceFormat1Choice? UninstructedBalance { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public IBalanceFormat1Choice? InstructedBalance { get; init; } 
    
    #nullable disable
}
