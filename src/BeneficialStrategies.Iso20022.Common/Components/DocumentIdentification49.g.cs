﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification49.  ISO2002 ID# _VyeOk5qLEeWcAIE4lEkF_Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document and type of link.
/// </summary>
public partial record DocumentIdentification49
{
    #nullable enable
    
    /// <summary>
    /// Identifies the document.
    /// </summary>
    public required IsoRestrictedFINXMax16Text Identification { get; init; } 
    /// <summary>
    /// Specifies when this document is to be processed relative to an other referred document.
    /// </summary>
    public ProcessingPosition22Choice_? LinkageType { get; init; } 
    
    #nullable disable
}
