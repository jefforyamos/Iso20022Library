﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginatorInformation1.  ISO2002 ID# __XpcEOCwEee83LAjB5Kqdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the originator. It is present only if required by the key management algorithm.
/// </summary>
public partial record OriginatorInformation1
{
    #nullable enable
    
    /// <summary>
    /// It may contain originator certificates associated with several different key management algorithms.
    /// </summary>
    public IsoMax5000Binary[] Certificate { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
