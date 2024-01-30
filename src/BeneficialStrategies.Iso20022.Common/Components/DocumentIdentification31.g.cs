﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification31.  ISO2002 ID# _e22_UTnXEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document and type of link.
/// </summary>
public partial record DocumentIdentification31
{
    #nullable enable
    
    /// <summary>
    /// Identifies the document.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies when this document is to be processed relative to another referred document.
    /// </summary>
    public IProcessingPosition7Choice? LinkageType { get; init; } 
    
    #nullable disable
}
