﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _IamycfIAEeaz_YGUGLjP6A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SupervisingAuthorityIdentification1Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to an institution using an external code list.
/// </summary>
public partial record ProprietaryIdentification : SupervisingAuthorityIdentification1Choice_
{
    public required ExternalAuthorityIdentification1Code Value { get; init; }
}
