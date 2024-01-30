﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LocalData4.  ISO2002 ID# _TPWQUcW7EeuhguwJmlgagQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
public partial record LocalData4
{
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    public required ISOMax3ALanguageCode Language { get; init; } 
    /// <summary>
    /// Short name of the party in the local language.
    /// </summary>
    public IsoMax70Text? ShortName { get; init; } 
    /// <summary>
    /// Legal Corporate Name of the party in the local language
    /// </summary>
    public IsoMax210Text? LegalCorporateName { get; init; } 
    /// <summary>
    /// Name and location of acceptor in the local language.  May only contain name when the location is specified elsewhere.
    /// </summary>
    public IsoMax200Text? NameAndLocation { get; init; } 
    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    public Address3? Address { get; init; } 
    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    public IsoMax512Text? AdditionalAddressInformation { get; init; } 
    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// </summary>
    public IsoMax512Text? AdditionalContactInformation { get; init; } 
    /// <summary>
    /// Additional local language data
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
