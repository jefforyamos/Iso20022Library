﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DefaultAction.  ISO2002 ID# _Qy_hNNp-Ed-ak6NoX_4Aeg_1216872806.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus1Choice;

/// <summary>
/// Default action is taken.
/// </summary>
public partial record DefaultAction : InstructionProcessingStatus1Choice_
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
