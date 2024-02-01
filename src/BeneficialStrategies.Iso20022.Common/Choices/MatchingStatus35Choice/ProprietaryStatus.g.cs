﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _2sTZ-Qd3Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus35Choice;

/// <summary>
/// Provides a proprietary status and a proprietary reason of the processing status of the trade.
/// </summary>
public partial record ProprietaryStatus : MatchingStatus35Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification30 ProprietaryStatusValue { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason4? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
