﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Qwdxptp-Ed-ak6NoX_4Aeg_-1167268674.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfPrice6Choice;

/// <summary>
/// Type of price expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ITypeOfPrice6Choice
{
    public required TypeOfPrice16Code Value { get; init; }
}
