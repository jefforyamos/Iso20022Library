﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GroupHeader84.  ISO2002 ID# _NRkhq249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the message.
/// </summary>
[DataContract]
[XmlType]
public partial record GroupHeader84
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the account servicing institution, and sent to the account owner or the party authorised to receive the message, to unambiguously identify the message.||Usage: The account servicing institution has to make sure that 'MessageIdentification' is unique per account owner for a pre-agreed period.
    /// </summary>
    [DataMember]
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [DataMember]
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Identification of the party that is receiving the message, when different from the account owner.
    /// </summary>
    [DataMember]
    public Party40Choice_? MessageRecipient { get; init; } 
    
    #nullable disable
}
