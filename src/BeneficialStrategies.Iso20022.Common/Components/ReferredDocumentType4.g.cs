﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReferredDocumentType4.  ISO2002 ID# _Xf7GCR77EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the document referred in the remittance information.
/// </summary>
public partial record ReferredDocumentType4
{
    #nullable enable
    
    /// <summary>
    /// Provides the type details of the referred document.
    /// </summary>
    public required IReferredDocumentType3Choice CodeOrProprietary { get; init; } 
    /// <summary>
    /// Identification of the issuer of the reference document type.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
    #nullable disable
}
