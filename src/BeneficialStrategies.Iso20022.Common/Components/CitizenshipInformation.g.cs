﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CitizenshipInformation.  ISO2002 ID# _QBhoB9p-Ed-ak6NoX_4Aeg_-1749124449.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record CitizenshipInformation
{
    #nullable enable
    
    /// <summary>
    /// Specifies the country where a person was born or is legally accepted as belonging to the country.
    /// </summary>
    public required NationalityCode Nationality { get; init; } 
    /// <summary>
    /// Indicates whether the person is a legal minor. It may depend on the nationality, the domicile country or the transaction in which the person is involved.
    /// </summary>
    public required IsoYesNoIndicator MinorIndicator { get; init; } 
    
    #nullable disable
}
