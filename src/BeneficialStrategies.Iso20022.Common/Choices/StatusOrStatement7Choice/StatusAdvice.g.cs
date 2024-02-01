﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatusAdvice.  ISO2002 ID# _RMPsUzs-EeWRTLSN0i0tng.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement7Choice;

/// <summary>
/// Identify the status advice and the transaction for which the status advice was requested.
/// </summary>
public partial record StatusAdvice : StatusOrStatement7Choice_
{
    #nullable enable
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    public required DocumentNumber5Choice_ Number { get; init; } 
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    public Identification15? References { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
