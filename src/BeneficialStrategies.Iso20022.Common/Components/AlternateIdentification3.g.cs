﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlternateIdentification3.  ISO2002 ID# _6bujcR5VEeWFEfGJQFSF5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification of a security.
/// </summary>
public partial record AlternateIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    public required IsoMax70Text Identification { get; init; } 
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    public required IIdentificationSource1Choice IdentificationSource { get; init; } 
    
    #nullable disable
}
