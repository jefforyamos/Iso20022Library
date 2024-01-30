﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesFinancingTransactionDetails45.  ISO2002 ID# _Jl3mUdBxEeihG9bKfarOOA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
public partial record SecuritiesFinancingTransactionDetails45
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    public IsoMax52Text? SecuritiesFinancingTradeIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    public IsoMax35Text? ClosingLegIdentification { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public ITerminationDate6Choice? TerminationDate { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    public IRateType35Choice? RateType { get; init; } 
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    public ILegalFramework3Choice? LegalFramework { get; init; } 
    /// <summary>
    /// Indicates whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 
    /// <summary>
    /// Indicates whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    public IsoYesNoIndicator? InterestPayment { get; init; } 
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    public RateName1? VariableRateSupport { get; init; } 
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    public Rate2? RepurchaseRate { get; init; } 
    /// <summary>
    /// Minimum number of days' notice a counterparty needs for terminating the transaction.
    /// </summary>
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    public AmountAndDirection21? TerminationTransactionAmount { get; init; } 
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    public IsoMax140Text? SecondLegNarrative { get; init; } 
    
    #nullable disable
}
