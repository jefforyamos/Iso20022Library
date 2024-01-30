﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalParameters1.  ISO2002 ID# _Q7Vk6Np-Ed-ak6NoX_4Aeg_934154443.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sort criteria.
/// </summary>
public partial record AdditionalParameters1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the country.
    /// </summary>
    public CountryCode? Country { get; init; } 
    /// <summary>
    /// Specifies the currency.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Specifies the geographical area, eg, Asia-Pacific, Europe, Middle-East.
    /// </summary>
    public IsoMax35Text? GeographicalArea { get; init; } 
    
    #nullable disable
}
