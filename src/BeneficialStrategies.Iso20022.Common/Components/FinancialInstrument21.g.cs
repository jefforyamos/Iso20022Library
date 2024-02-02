﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument21.  ISO2002 ID# _SbwOyNp-Ed-ak6NoX_4Aeg_-1299179113.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[DataContract]
[XmlType]
public partial record FinancialInstrument21
{
    #nullable enable
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, for example, 'Class A', 'Class 2'.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClassType { get; init; } 
    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    [DataMember]
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [DataMember]
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [DataMember]
    public IsoMax140Text? ProductGroup { get; init; } 
    /// <summary>
    /// Name of the umbrella fund in which financial instrument is contained.
    /// </summary>
    [DataMember]
    public IsoMax35Text? UmbrellaName { get; init; } 
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? BaseCurrency { get; init; } 
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? DenominationCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [DataMember]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? DualFundIndicator { get; init; } 
    /// <summary>
    /// Country where the fund has legal domicile as reflected in the ISIN classification.
    /// </summary>
    [DataMember]
    public CountryCode? CountryOfDomicile { get; init; } 
    /// <summary>
    /// Countries where the fund is registered for distribution.
    /// </summary>
    [DataMember]
    public ValueList<CountryCode> RegisteredDistributionCountry { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
