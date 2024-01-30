﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Geolocation1.  ISO2002 ID# _4ORaINj8EeiojJsa6FYyew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Geographic location specified by geographic or UTM coordinates.
/// </summary>
public partial record Geolocation1
{
    #nullable enable
    
    /// <summary>
    /// Geographic location specified by geographic coordinates.
    /// </summary>
    public GeolocationGeographicCoordinates1? GeographicCoordinates { get; init; } 
    /// <summary>
    /// Geographic location specified by UTM coordinates.
    /// </summary>
    public GeolocationUTMCoordinates1? UTMCoordinates { get; init; } 
    
    #nullable disable
}
