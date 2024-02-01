﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes93.  ISO2002 ID# _kkuQnbQYEeeKRKrD60ELBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
public partial record FinancialInstrumentAttributes93
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification19 SecurityIdentification { get; init; } 
    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    public IsoDecimalNumber? Quantity { get; init; } 
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    public RenounceableEntitlementStatusTypeFormat3Choice_? RenounceableEntitlementStatusType { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType25Choice_? FractionDisposition { get; init; } 
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
    public required DateFormat30Choice_ ExpiryDate { get; init; } 
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    public required DateFormat30Choice_ PostingDate { get; init; } 
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    public Period11? TradingPeriod { get; init; } 
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    public BalanceFormat5Choice_? UninstructedBalance { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public BalanceFormat5Choice_? InstructedBalance { get; init; } 
    
    #nullable disable
}
