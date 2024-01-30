﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DateAndPlaceOfBirth1.  ISO2002 ID# _jU8IEa9UEeeJJK1oRb-jTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and place of birth of a person.
/// </summary>
public partial record DateAndPlaceOfBirth1
{
    #nullable enable
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    public required IsoISODate BirthDate { get; init; } 
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    /// <summary>
    /// City where a person was born.
    /// </summary>
    public required IsoMax35Text CityOfBirth { get; init; } 
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    public required CountryCode CountryOfBirth { get; init; } 
    
    #nullable disable
}
