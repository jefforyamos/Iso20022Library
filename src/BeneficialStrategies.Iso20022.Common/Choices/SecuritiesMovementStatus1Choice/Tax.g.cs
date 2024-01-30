﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Tax.  ISO2002 ID# _pNlqwOCzEei2UYJ62ws-Fw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesMovementStatus1Choice;

/// <summary>
/// At least one security cannot be used as collateral because a tax event is due in the next few days.
/// </summary>
public partial record Tax : ISecuritiesMovementStatus1Choice
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
