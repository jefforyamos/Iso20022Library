﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingAmendmentMessage1.  ISO2002 ID# _98eF8nltEeG7BsjMvd1mEw_1389753684.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contents of an Undertaking Amendment message.
/// </summary>
[DataContract]
[XmlType]
public partial record UndertakingAmendmentMessage1
{
    #nullable enable
    
    /// <summary>
    /// Details related to the proposed undertaking amendment.
    /// </summary>
    [DataMember]
    public required Amendment1 UndertakingAmendmentDetails { get; init; } 
    /// <summary>
    /// Digital signature of the proposed amendment.
    /// </summary>
    [DataMember]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    #nullable disable
}
