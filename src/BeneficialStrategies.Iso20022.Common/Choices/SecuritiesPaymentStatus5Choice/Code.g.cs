﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cgvT8znAEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesPaymentStatus5Choice;

/// <summary>
/// Securities payment status expressed as an ISO 20022 code.
/// </summary>
public partial record Code : SecuritiesPaymentStatus5Choice_
{
    public required SecuritiesPaymentStatus1Code Value { get; init; }
}
