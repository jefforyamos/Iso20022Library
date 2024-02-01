﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _cel4EZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus4Choice;

/// <summary>
/// Proprietary status related to the event processing.
/// </summary>
public partial record ProprietaryStatus : EventProcessingStatus4Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification47 ProprietaryStatusValue { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason5? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
