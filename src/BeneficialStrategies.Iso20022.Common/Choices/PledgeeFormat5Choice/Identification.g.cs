﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _YxN_49LGEeiN28wlpBQScw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat5Choice;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged, expressed as a code and a narrative description.
/// </summary>
public partial record Identification : IPledgeeFormat5Choice
{
    #nullable enable
    /// <summary>
    /// Additional information about the entity to which the financial instruments are pledged.
    /// </summary>
    public IsoMax35Text? IdentificationValue { get; init; } 
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    public required PledgeeType1Code PledgeeType { get; init; } 
    #nullable disable
}
