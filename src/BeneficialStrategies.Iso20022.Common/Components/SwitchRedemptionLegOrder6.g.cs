﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchRedemptionLegOrder6.  ISO2002 ID# _4kpxMzbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Redemption leg, or switch-out, of a switch transaction.
/// </summary>
public partial record SwitchRedemptionLegOrder6
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    public IsoMax35Text? LegIdentification { get; init; } 
    /// <summary>
    /// Investment fund class related to the redemption leg of the order.
    /// </summary>
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Amount of money, number of units or percentage for the subscription leg of the switch order.
    /// </summary>
    public IFinancialInstrumentQuantity29Choice? FinancialInstrumentQuantityChoice { get; init; } 
    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the gross amount.
    /// </summary>
    public FeeAndTax1? TransactionOverhead { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters12? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Part of an investor's retained subscription amount that is returned by the fund in order to reimburse preliminary incentive/performance fees.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    
    #nullable disable
}
