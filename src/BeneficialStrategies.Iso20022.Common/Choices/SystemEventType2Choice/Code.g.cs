﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _72FYEKMgEeCJ6YNENx4h-w_1131843970.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemEventType2Choice;

/// <summary>
/// Type of system event that has occurred, expressed in a coded form.
/// </summary>
public partial record Code : ISystemEventType2Choice
{
    public required SystemEventType2Code Value { get; init; }
}
