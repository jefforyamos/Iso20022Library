﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TypeAndIdentification.  ISO2002 ID# _9NxogTnZEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat3Choice;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a BIC.
/// </summary>
public partial record TypeAndIdentification : PledgeeFormat3Choice_
{
    #nullable enable
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged, expressed as a BIC.
    /// </summary>
    public required IsoAnyBICIdentifier Identification { get; init; } 
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    public required PledgeeType1Code PledgeeType { get; init; } 
    #nullable disable
}
