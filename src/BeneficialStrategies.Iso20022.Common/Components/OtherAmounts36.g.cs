﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherAmounts36.  ISO2002 ID# _6InnD5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
public partial record OtherAmounts36
{
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection72? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public AmountAndDirection72? ChargesFees { get; init; } 
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    public AmountAndDirection72? TradeAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public AmountAndDirection72? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    public AmountAndDirection72? LocalTax { get; init; } 
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    public AmountAndDirection72? LocalBrokerCommission { get; init; } 
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    public AmountAndDirection72? Other { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public AmountAndDirection72? StampDuty { get; init; } 
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    public AmountAndDirection72? TransactionTax { get; init; } 
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    public AmountAndDirection72? WithholdingTax { get; init; } 
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    public AmountAndDirection72? ConsumptionTax { get; init; } 
    
    #nullable disable
}
