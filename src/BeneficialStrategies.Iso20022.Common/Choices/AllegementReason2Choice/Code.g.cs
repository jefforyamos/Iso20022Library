﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _3m3kwQd3Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AllegementReason2Choice;

/// <summary>
/// Specifies the reason why the instruction has been alleged.
/// </summary>
public partial record Code : IAllegementReason2Choice
{
    public required AllegementReason1Code Value { get; init; }
}
