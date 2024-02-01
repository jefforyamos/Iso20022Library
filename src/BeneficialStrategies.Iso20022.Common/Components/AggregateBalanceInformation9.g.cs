﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalanceInformation9.  ISO2002 ID# _R8KIudp-Ed-ak6NoX_4Aeg_-103812878.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall position, in a single security, held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateBalanceInformation9
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising a financial instrument other than a investment funds.
    /// </summary>
    public FinancialInstrumentAttributes8? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    public FinancialInstrument21? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Elements used to calculate the valuation haircut.
    /// </summary>
    public BasicCollateralValuation1Details? ValuationHaircutDetails { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public required Balance1 AggregateBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    public BalanceQuantity5Choice_? AvailableBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    public BalanceQuantity5Choice_? NotAvailableBalance { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation5[] PriceDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms1[] ForeignExchangeDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown3[] QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    public SubBalanceInformation5[] BalanceBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation5[] AdditionalBalanceBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    public AggregateBalancePerSafekeepingPlace8[] BalanceAtSafekeepingPlace { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    public IsoMax350Text? HoldingAdditionalDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension2[] Extension { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
