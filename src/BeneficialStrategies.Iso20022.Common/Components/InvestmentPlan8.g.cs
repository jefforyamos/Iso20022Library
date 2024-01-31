﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentPlan8.  ISO2002 ID# _SsJ5oRRdEeOKWo1NF21OVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
public partial record InvestmentPlan8
{
    #nullable enable
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    public required IFrequency20Choice Frequency { get; init; } 
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    public IsoISODate? EndDate { get; init; } 
    /// <summary>
    /// Amount of the periodical payments.
    /// </summary>
    public required IUnitsOrAmount1Choice Quantity { get; init; } 
    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including all charges, commissions, tax). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Number of pre-paid instalment periods at the time the investment plan is created.
    /// </summary>
    public IsoNumber? InitialNumberOfInstalments { get; init; } 
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    public IsoNumber? TotalNumberOfInstalments { get; init; } 
    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    public IReadOnlyCollection<Repartition2> SecurityDetails { get; init; } = [];
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan and to be either inserted or deleted.
    /// </summary>
    public IReadOnlyCollection<InvestmentFundCashSettlementInformation8> ModifiedCashSettlement { get; init; } = [];
    /// <summary>
    /// Reference of the underlying investment contract. In some markets, such as Italy, this might be required to segregate holdings between the same investment account.
    /// </summary>
    public IsoMax35Text? ContractReference { get; init; } 
    /// <summary>
    /// Reference of the previous contract to which this savings or withdrawal plan is related.
    /// </summary>
    public IsoMax35Text? RelatedContractReference { get; init; } 
    /// <summary>
    /// Identification of the product as designated by the fund manager. In some markets, such as Italy, the financial product or service related to a savings plan or withdrawal plan are identified by a product identification or number.
    /// </summary>
    public IsoMax35Text? ProductIdentification { get; init; } 
    /// <summary>
    /// Reference of the underlying service level agreement (SLA) governing charges and commission.
    /// </summary>
    public IsoMax35Text? SLAChargeAndCommissionReference { get; init; } 
    /// <summary>
    /// Specifies the type of insurance contract to which the savings investment plan is linked.
    /// </summary>
    public IInsuranceType1Choice? InsuranceCover { get; init; } 
    
    #nullable disable
}
