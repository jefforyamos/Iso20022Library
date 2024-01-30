﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _IamycfIAEeaz_YGUGLjP6A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SupervisingAuthorityIdentification1Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to an institution using an external code list.
/// </summary>
public partial record ProprietaryIdentification : ISupervisingAuthorityIdentification1Choice
{
    public required ExternalAuthorityIdentification1Code Value { get; init; }
}
