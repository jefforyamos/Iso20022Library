﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _65NaQffUEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus8Choice;

/// <summary>
/// Specifies a choice of status for the processing of an intra-position movement.
/// </summary>
public partial record Proprietary : IIntraPositionProcessingStatus8Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification47 ProprietaryStatus { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason5? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
