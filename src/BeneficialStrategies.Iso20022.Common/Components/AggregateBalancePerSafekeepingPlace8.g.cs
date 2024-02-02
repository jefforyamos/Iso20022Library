﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalancePerSafekeepingPlace8.  ISO2002 ID# _R73Nx9p-Ed-ak6NoX_4Aeg_1783598850.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
[DataContract]
[XmlType]
public partial record AggregateBalancePerSafekeepingPlace8
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [DataMember]
    public required SafekeepingPlaceFormat3Choice_ SafekeepingPlace { get; init; } 
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [DataMember]
    public MarketIdentification5? PlaceOfListing { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [DataMember]
    public required Balance1 AggregateBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is available.
    /// </summary>
    [DataMember]
    public BalanceQuantity5Choice_? AvailableBalance { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance that is not available.
    /// </summary>
    [DataMember]
    public BalanceQuantity5Choice_? NotAvailableBalance { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    [DataMember]
    public ValueList<PriceInformation5> PriceDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [DataMember]
    public ValueList<ForeignExchangeTerms1> ForeignExchangeDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [DataMember]
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    [DataMember]
    public BalanceAmounts3? AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    [DataMember]
    public BalanceAmounts3? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [DataMember]
    public ValueList<QuantityBreakdown3> QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    [DataMember]
    public ValueList<SubBalanceInformation5> BalanceBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [DataMember]
    public ValueList<AdditionalBalanceInformation5> AdditionalBalanceBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    [DataMember]
    public IsoMax350Text? HoldingAdditionalDetails { get; init; } 
    
    #nullable disable
}
