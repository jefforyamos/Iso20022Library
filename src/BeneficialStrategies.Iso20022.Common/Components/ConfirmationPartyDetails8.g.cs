﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConfirmationPartyDetails8.  ISO2002 ID# _8KGsYY-iEeaEa8S_GI1QNA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[DataContract]
[XmlType]
public partial record ConfirmationPartyDetails8
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun & Bradstreet Identification.
    /// </summary>
    [DataMember]
    public required PartyIdentification117Choice_ Identification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [DataMember]
    public AlternatePartyIdentification8? AlternateIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [DataMember]
    public PartyTextInformation5? AdditionalInformation { get; init; } 
    
    #nullable disable
}
