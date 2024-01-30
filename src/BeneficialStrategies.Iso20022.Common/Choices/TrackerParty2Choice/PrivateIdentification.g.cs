﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PrivateIdentification.  ISO2002 ID# _dtxoxWOTEeq5Ar_w98FvsA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TrackerParty2Choice;

/// <summary>
/// Unique and unambiguous identification of a person, for example a passport.
/// </summary>
public partial record PrivateIdentification : ITrackerParty2Choice
{
    #nullable enable
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericPersonIdentification1? Other { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
