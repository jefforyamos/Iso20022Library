﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegistrationReason1.  ISO2002 ID# _xoFroEAbEeC4mKrqv7wPJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason of registration.
/// </summary>
public partial record RegistrationReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reaoson of the holding status.
    /// </summary>
    public required Registration3Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
