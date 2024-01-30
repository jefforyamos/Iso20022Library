﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification34.  ISO2002 ID# _celQqZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document as well as the document number.
/// </summary>
public partial record DocumentIdentification34
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    public required IDocumentIdentification4Choice Identification { get; init; } 
    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    public IDocumentNumber6Choice? DocumentNumber { get; init; } 
    
    #nullable disable
}
