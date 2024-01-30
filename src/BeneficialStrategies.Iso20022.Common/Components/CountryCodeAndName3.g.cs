﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CountryCodeAndName3.  ISO2002 ID# _LwvhYBIgEeamBoux7a_UUg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a country by its code and its name.
/// </summary>
public partial record CountryCodeAndName3
{
    #nullable enable
    
    /// <summary>
    /// Country is specified by its code.
    /// </summary>
    public required CountryCode Code { get; init; } 
    /// <summary>
    /// Country is specified by its name.
    /// </summary>
    public required IsoMax70Text Name { get; init; } 
    
    #nullable disable
}
