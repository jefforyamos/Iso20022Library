﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherIdentification.  ISO2002 ID# _QEW5mdp-Ed-ak6NoX_4Aeg_-315280529.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType1Choice;

/// <summary>
/// Identifier issued to a person for which no specific identifier has been defined.
/// </summary>
public partial record OtherIdentification : IPersonIdentificationType1Choice
{
    #nullable enable
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
    /// </summary>
    public required IsoMax35Text IdentificationType { get; init; } 
    #nullable disable
}
