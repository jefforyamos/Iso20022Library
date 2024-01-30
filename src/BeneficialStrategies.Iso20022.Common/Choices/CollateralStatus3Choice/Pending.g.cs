﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Pending.  ISO2002 ID# _g1stYOCgEei2UYJ62ws-Fw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralStatus3Choice;

/// <summary>
/// Instruction is pending.
/// </summary>
public partial record Pending : ICollateralStatus3Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    public GenericIdentification30? Reason { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
