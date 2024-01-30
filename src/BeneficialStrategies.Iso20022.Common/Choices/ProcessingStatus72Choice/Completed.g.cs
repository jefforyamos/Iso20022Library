﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Completed.  ISO2002 ID# _a2nK1-LtEeWOD7aAy2fAcA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus72Choice;

/// <summary>
/// Instruction has been completed by the executing party.
/// </summary>
public partial record Completed : IProcessingStatus72Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason of the Status.
    /// </summary>
    public ProprietaryReason4? Reason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
