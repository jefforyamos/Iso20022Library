﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QvHt19p-Ed-ak6NoX_4Aeg_2137358938.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FormOfSecurity2Choice;

/// <summary>
/// Form of the security expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IFormOfSecurity2Choice
{
    public required FormOfSecurity1Code Value { get; init; }
}
