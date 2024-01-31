﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentPlan14.  ISO2002 ID# _q3k0QU_eEeaB8-OWTiMVrQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
public partial record InvestmentPlan14
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
    /// Indicates whether an ordered amount is a gross amount (including transaction overhead). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference2Code? IncomePreference { get; init; } 
    /// <summary>
    /// Initial amount or number of initial instalments.
    /// </summary>
    public IInitialAmount1Choice? InitialAmount { get; init; } 
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
    public IReadOnlyCollection<Repartition5> SecurityDetails { get; init; } = [];
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan.
    /// </summary>
    public IReadOnlyCollection<CashSettlement1> CashSettlement { get; init; } = [];
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
    /// Reference of the underlying service level agreement (SLA) governing fees.
    /// </summary>
    public IsoMax35Text? SLAChargeAndCommissionReference { get; init; } 
    /// <summary>
    /// Specifies the type of insurance contract to which the savings investment plan is linked.
    /// </summary>
    public IInsuranceType2Choice? InsuranceCover { get; init; } 
    /// <summary>
    /// Status of the savings or withdrawal investment plan.
    /// </summary>
    public IPlanStatus2Choice? PlanStatus { get; init; } 
    /// <summary>
    /// Role or function of the instalment manager.
    /// </summary>
    public IPartyRole4Choice? InstalmentManagerRole { get; init; } 
    
    #nullable disable
}
