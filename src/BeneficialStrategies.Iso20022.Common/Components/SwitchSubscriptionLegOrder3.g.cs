﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchSubscriptionLegOrder3.  ISO2002 ID# _SLXCVdp-Ed-ak6NoX_4Aeg_-708775222.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Subscription leg, or switch-in, of a switch order.
/// </summary>
public partial record SwitchSubscriptionLegOrder3
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    public IsoMax35Text? LegIdentification { get; init; } 
    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    public FinancialInstrumentQuantity6Choice_? FinancialInstrumentQuantityChoice { get; init; } 
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    public InvestmentAccount21? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    public Charge17[] ChargeDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    public Commission10[] CommissionDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    public Tax16[] TaxDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    
    #nullable disable
}
