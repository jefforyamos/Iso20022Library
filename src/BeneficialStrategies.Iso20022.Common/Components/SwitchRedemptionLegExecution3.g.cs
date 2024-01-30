﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchRedemptionLegExecution3.  ISO2002 ID# _R2Wbsdp-Ed-ak6NoX_4Aeg_-1694554730.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of the redemption part, in a switch between investment funds or investment fund classes.
/// </summary>
public partial record SwitchRedemptionLegExecution3
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
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Number of investment funds units redeemed.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    public InvestmentAccount21? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Portion of the investor's holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    /// <summary>
    /// Amount of money paid to the investor as a result of the redemption after deduction of charges, commissions and taxes.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Amount of money resulting from the redemption before deduction of charges, commissions and taxes.|[Quantity * Price].
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossAmount { get; init; } 
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    public required IDateAndDateTimeChoice TradeDateTime { get; init; } 
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    public required UnitPrice10 PriceDetails { get; init; } 
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    public IProfitAndLoss1Choice? InterimProfitAmount { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
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
    public TotalCharges3? ChargeGeneralDetails { get; init; } 
    /// <summary>
    /// Commission for the execution of an investment fund order.
    /// </summary>
    public TotalCommissions3? CommissionGeneralDetails { get; init; } 
    /// <summary>
    /// Tax applicable to execution of an investment fund order.
    /// </summary>
    public TotalTaxes3? TaxGeneralDetails { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    
    #nullable disable
}
