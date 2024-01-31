﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MissingOrIncorrectData1.  ISO2002 ID# _7MMxcdjKEeq5MfBBxQig1Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further information on the reason for the unable to apply investigation.
/// </summary>
public partial record MissingOrIncorrectData1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
    /// </summary>
    public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; } 
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    public IReadOnlyCollection<UnableToApplyMissing2> MissingInformation { get; init; } = [];
    /// <summary>
    /// Indicates, in a coded form, the incorrect information.
    /// </summary>
    public IReadOnlyCollection<UnableToApplyIncorrect2> IncorrectInformation { get; init; } = [];
    
    #nullable disable
}
