﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchSubscriptionLegExecution2.  ISO2002 ID# _VX86K9p-Ed-ak6NoX_4Aeg_-468679588.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of the subscription part, in a switch between investment funds or investment fund classes.
/// </summary>
public partial record SwitchSubscriptionLegExecution2
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    public IsoMax35Text? LegIdentification { get; init; } 
    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    public IsoMax35Text? LegExecutionIdentification { get; init; } 
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Net amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    public required IsoActiveCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Gross amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossAmount { get; init; } 
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    public required UnitPrice5 PriceDetails { get; init; } 
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public CurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Charge for the execution of an order.
    /// </summary>
    public TotalCharges2? ChargeGeneralDetails { get; init; } 
    /// <summary>
    /// Commission for the execution of an investment fund order.
    /// </summary>
    public TotalCommissions2? CommissionGeneralDetails { get; init; } 
    /// <summary>
    /// Tax applicable to execution of an investment fund order.
    /// </summary>
    public TotalTaxes2? TaxGeneralDetails { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    
    #nullable disable
}
