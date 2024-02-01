﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnderInvestigation.  ISO2002 ID# _0k3gxAlIEeGATtfOBToyew_1137213663.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus20Choice;

/// <summary>
/// Allegement is under investigation.
/// </summary>
public partial record UnderInvestigation : PendingStatus20Choice_
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
