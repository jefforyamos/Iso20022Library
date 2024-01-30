﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification32.  ISO2002 ID# _ni5s8TnYEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document as well as the document number and type of link.
/// </summary>
public partial record DocumentIdentification32
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    public required IDocumentIdentification3Choice Identification { get; init; } 
    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    public IDocumentNumber5Choice? DocumentNumber { get; init; } 
    /// <summary>
    /// Specifies when this document is to be processed relative to another referred document.
    /// </summary>
    public IProcessingPosition7Choice? LinkageType { get; init; } 
    
    #nullable disable
}
