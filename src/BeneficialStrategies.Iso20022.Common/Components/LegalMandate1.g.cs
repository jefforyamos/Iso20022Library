﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LegalMandate1.  ISO2002 ID# _bhYnwEJ4EeGuetKibuqsKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the legal basis of the request.
/// </summary>
public partial record LegalMandate1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the legal mandate paragraph in law which gives power to the authority's request.
    /// </summary>
    public required IsoMax35Text Paragraph { get; init; } 
    /// <summary>
    /// Specifies any additional information describing how or why the paragraph of law should be applied.
    /// </summary>
    public IsoMax350Text? Disclaimer { get; init; } 
    
    #nullable disable
}
