﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UXIWUNp-Ed-ak6NoX_4Aeg_1175171282.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason2Choice;

/// <summary>
/// Specifies the reason why the request was denied.
/// </summary>
public partial record Code : IDeniedReason2Choice
{
    public required DeniedReason4Code Value { get; init; }
}
