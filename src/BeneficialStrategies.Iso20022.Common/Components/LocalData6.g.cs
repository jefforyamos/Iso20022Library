﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LocalData6.  ISO2002 ID# _cqCrUcXKEeumGdYElfgmbw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
public partial record LocalData6
{
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    public required ISOMax3ALanguageCode Language { get; init; } 
    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of where the card was mailed to.
    /// </summary>
    public Address3? MailingAddress { get; init; } 
    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the Unstructured mailing address where the card was mailed to.
    /// </summary>
    public IsoMax512Text? MailingAddressUnstructured { get; init; } 
    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the postal code where the card was mailed from.
    /// </summary>
    public IsoMax35Text? MailedFromPostalCode { get; init; } 
    /// <summary>
    /// Local language equivalent of the Cardholder name.
    /// </summary>
    public CardholderName2? CardholderName { get; init; } 
    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    public AdditionalInformation22? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional local language data
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
