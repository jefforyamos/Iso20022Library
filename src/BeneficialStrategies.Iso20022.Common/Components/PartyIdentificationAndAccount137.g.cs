﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount137.  ISO2002 ID# _5nJRUZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[DataContract]
[XmlType]
public partial record PartyIdentificationAndAccount137
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [DataMember]
    public required PartyIdentification104Choice_ Identification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [DataMember]
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [DataMember]
    public AlternatePartyIdentification9? AlternateIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [DataMember]
    public PartyTextInformation3? AdditionalInformation { get; init; } 
    
    #nullable disable
}
