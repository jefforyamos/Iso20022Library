﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PrivateIdentification.  ISO2002 ID# _Pa7iFtp-Ed-ak6NoX_4Aeg_567091032.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party6Choice;

/// <summary>
/// Unique and unambiguous identification of a person, for example a passport.
/// </summary>
public partial record PrivateIdentification : IParty6Choice
{
    #nullable enable
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; init; } 
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericPersonIdentification1? Other { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
