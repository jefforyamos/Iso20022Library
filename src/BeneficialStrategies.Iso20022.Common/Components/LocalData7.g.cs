﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LocalData7.  ISO2002 ID# _bTHMccrfEeuQjLd-KKZrCg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
public partial record LocalData7
{
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    public required ISOMax3ALanguageCode Language { get; init; } 
    /// <summary>
    /// Name of the cardholder in the local language.
    /// </summary>
    public CardholderName2? CardholderName { get; init; } 
    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    public Address3? Address { get; init; } 
    /// <summary>
    /// Additional local language data
    /// </summary>
    public AdditionalData1[] AdditionalData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
