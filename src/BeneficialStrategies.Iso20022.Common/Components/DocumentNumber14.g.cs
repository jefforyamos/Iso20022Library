﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentNumber14.  ISO2002 ID# _8QbAo5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document.
/// </summary>
public partial record DocumentNumber14
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    public required IDocumentNumber6Choice Number { get; init; } 
    
    #nullable disable
}
