﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _64ajF_pNEeCLrd06h-p51g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat7Choice;

/// <summary>
/// Standard code to specify the additional business process "tax refund" linked to a corporate action event.
/// </summary>
public partial record Code : IAdditionalBusinessProcessFormat7Choice
{
    public required AdditionalBusinessProcess4Code Value { get; init; }
}
