﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q-K2dNp-Ed-ak6NoX_4Aeg_-1440303164.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CustomerHandlingInstructionChoice;

/// <summary>
/// Customer handling instruction is defined using a code.
/// </summary>
public partial record Code : ICustomerHandlingInstructionChoice
{
    public required CustomerHandlingInstructions1Code Value { get; init; }
}
