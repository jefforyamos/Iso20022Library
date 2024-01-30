﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesFinancingTransactionDetails46.  ISO2002 ID# _6sljfffVEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
public partial record SecuritiesFinancingTransactionDetails46
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    public IsoRestrictedFINXMax52Text? SecuritiesFinancingTradeIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClosingLegIdentification { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public ITerminationDate7Choice? TerminationDate { get; init; } 
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    public IDateAndDateTime2Choice? RateChangeDate { get; init; } 
    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    public IDateAndDateTime2Choice? EarliestCallBackDate { get; init; } 
    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    public IDateAndDateTime2Choice? CommissionCalculationDate { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    public IRateType67Choice? RateType { get; init; } 
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    public IRevaluationIndicator4Choice? Revaluation { get; init; } 
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    public ILegalFramework4Choice? LegalFramework { get; init; } 
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    public IInterestComputationMethodFormat5Choice? InterestComputationMethod { get; init; } 
    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 
    /// <summary>
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    public IsoYesNoIndicator? InterestPayment { get; init; } 
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    public RateName2? VariableRateSupport { get; init; } 
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    public Rate2? RepurchaseRate { get; init; } 
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender's risk.
    /// </summary>
    public Rate2? StockLoanMargin { get; init; } 
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    public Rate2? SecuritiesHaircut { get; init; } 
    /// <summary>
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    public Rate2? ChargesRate { get; init; } 
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    public IRateOrName2Choice? PricingRate { get; init; } 
    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    public Rate2? Spread { get; init; } 
    /// <summary>
    /// Minimum number of days' notice a counterparty needs for terminating the transaction.
    /// </summary>
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 
    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    public AmountAndDirection59? DealAmount { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    public AmountAndDirection59? ForfeitAmount { get; init; } 
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    public AmountAndDirection59? PremiumAmount { get; init; } 
    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; init; } 
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    public IsoRestrictedFINXMax140Text? SecondLegNarrative { get; init; } 
    
    #nullable disable
}
