﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QtL0Jtp-Ed-ak6NoX_4Aeg_566735114.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType2Choice;

/// <summary>
/// Type of securities financing transaction process expressed as an ISO 20022 code.
/// </summary>
public partial record Code : RepurchaseType2Choice_
{
    public required RepurchaseType4Code Value { get; init; }
}
