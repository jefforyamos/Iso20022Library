﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherIdentification2.  ISO2002 ID# _uP5vYwgWEeCVlvYcV4HKqQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other accepted financial instrument's identification than ISIN.
/// </summary>
public partial record OtherIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    public required IsoRestrictedFINXMax31Text Identification { get; init; } 
    /// <summary>
    /// Identifies the suffix of the security identification.
    /// </summary>
    public IsoMax16Text? Suffix { get; init; } 
    /// <summary>
    /// Type of the identification.
    /// </summary>
    public required IdentificationSource4Choice_ Type { get; init; } 
    
    #nullable disable
}
