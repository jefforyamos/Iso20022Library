﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonIdentification13.  ISO2002 ID# _jJrTQa9UEeeJJK1oRb-jTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
public partial record PersonIdentification13
{
    #nullable enable
    
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericPersonIdentification1[] Other { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
