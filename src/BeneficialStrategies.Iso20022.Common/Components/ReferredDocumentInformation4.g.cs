﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReferredDocumentInformation4.  ISO2002 ID# _W7TRoabjEeKvUvwX_r3tzA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the documents referred to in the remittance information.
/// </summary>
public partial record ReferredDocumentInformation4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    public ReferredDocumentType2? Type { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    public IsoMax35Text? Number { get; init; } 
    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    public IsoISODate? RelatedDate { get; init; } 
    /// <summary>
    /// Set of elements used to provide the content of the referred document line.
    /// </summary>
    public DocumentLineInformation1[] LineDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
