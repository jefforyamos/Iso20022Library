﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _fDHA-VhFEeOMYfRGLS0NbA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus43Choice;

/// <summary>
/// Status of the standing settlement instruction, cancellation or deletion is expressed in a bilaterally agreed manner.
/// </summary>
public partial record ProprietaryStatus : ProcessingStatus43Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status of the instruction.
    /// </summary>
    public required GenericIdentification36 Status { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the status.
    /// </summary>
    public required ProprietaryReason1Choice_ Reason { get; init; } 
    /// <summary>
    /// Additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
