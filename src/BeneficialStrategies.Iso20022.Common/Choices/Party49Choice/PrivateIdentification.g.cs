﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PrivateIdentification.  ISO2002 ID# _dbeBZeEpEemRzcIkmUETeA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party49Choice;

/// <summary>
/// Unique and unambiguous identification of a person, for example a passport.
/// </summary>
public partial record PrivateIdentification : Party49Choice_
{
    #nullable enable
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericPersonIdentification1? Other { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
