﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _wCNH5MlcEeW3r6pl_9_bpw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SystemEventType3Choice;

/// <summary>
/// Type of system event, as published in an external code list.
/// </summary>
public partial record Code : ISystemEventType3Choice
{
    public required ExternalSystemEvent1Code Value { get; init; }
}
