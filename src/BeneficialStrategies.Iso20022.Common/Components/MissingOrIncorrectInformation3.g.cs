﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MissingOrIncorrectInformation3.  ISO2002 ID# _d3zpQUgqEeaGKYpLDboHPQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further information on the reason for the unable to apply investigation.
/// </summary>
public partial record MissingOrIncorrectInformation3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
    /// </summary>
    public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; } 
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    // public IReadOnlyCollection<UnableToApplyMissing1> MissingInformation { get; init; }
    /// <summary>
    /// Indicates, in a coded form, the incorrect information.
    /// </summary>
    // public IReadOnlyCollection<UnableToApplyIncorrect1> IncorrectInformation { get; init; }
    
    #nullable disable
}
