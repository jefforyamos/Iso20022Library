﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StructuredRegulatoryReporting3.  ISO2002 ID# _SnhZ4tp-Ed-ak6NoX_4Aeg_797411932.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and statutory requirements.
/// </summary>
public partial record StructuredRegulatoryReporting3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the information supplied in the regulatory reporting details.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Date related to the specified type of regulatory reporting details.
    /// </summary>
    public IsoISODate? Date { get; init; } 
    /// <summary>
    /// Country related to the specified type of regulatory reporting details.
    /// </summary>
    public CountryCode? Country { get; init; } 
    /// <summary>
    /// Specifies the nature, purpose, and reason for the transaction to be reported for regulatory and statutory requirements in a coded form.
    /// </summary>
    public IsoMax10Text? Code { get; init; } 
    /// <summary>
    /// Amount of money to be reported for regulatory and statutory requirements.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Additional details that cater for specific domestic regulatory requirements.
    /// </summary>
    public IsoMax35Text[] Information { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
