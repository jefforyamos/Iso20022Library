﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeographicCoordinates1.  ISO2002 ID# _O80mgIn5EeShMpas3885ww.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location on the Earth specified by two numbers representing vertical and horizontal position.
/// </summary>
public partial record GeographicCoordinates1
{
    #nullable enable
    
    /// <summary>
    /// Latitude measured in degrees, minutes and seconds, following by 'N' for the north and 'S' for the south of the equator (for example 48°51'29" N for the Eiffel Tower latitude).
    /// </summary>
    public required IsoMax16Text Latitude { get; init; } 
    /// <summary>
    /// Angular measurement of the distance of a location on the earth east or west of the Greenwich observatory.
    /// The longitude is measured in degrees, minutes and seconds, following by 'E' for the east and 'W' for the west (for example 2°17'40" E for the Eiffel Tower longitude).
    /// </summary>
    public required IsoMax16Text Longitude { get; init; } 
    
    #nullable disable
}
