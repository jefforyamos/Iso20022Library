﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryStatus.  ISO2002 ID# _A4aEJ9okEeC60axPepSq7g_1828723592.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus9Choice;

/// <summary>
/// Provides a proprietary status and a proprietary reason of the processing status of the trade.
/// </summary>
public partial record ProprietaryStatus : IMatchingStatus9Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the status related to an instruction.
    /// </summary>
    public required GenericIdentification20 ProprietaryStatusValue { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason related to a proprietary status.
    /// </summary>
    public ProprietaryReason1? ProprietaryReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
