﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusChangeRequestAcceptanceV02.  ISO2002 ID# _v33NZ9E8Ed-BzquC8wXy7w_-1262525653.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// Scope
/// The StatusChangeRequestAcceptance message is sent by the party requested to accept or reject the request of a change in the status of a transaction to the matching application.
/// This message is used to inform about the acceptance of a request to change the status of a transaction.
/// Usage
/// The StatusChangeRequestAcceptance message can be sent by the party requested to accept or reject a request to change the status of a transaction to inform that it accepts the request.
/// The message can be sent in response to a StatusChangeRequestNotification message.
/// The rejection of a request to change the status of a transaction can be achieved by sending a StatusChangeRequestRejection message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusChangeRequestAcceptance message is sent by the party requested to accept or reject the request of a change in the status of a transaction to the matching application.|This message is used to inform about the acceptance of a request to change the status of a transaction.|Usage|The StatusChangeRequestAcceptance message can be sent by the party requested to accept or reject a request to change the status of a transaction to inform that it accepts the request.|The message can be sent in response to a StatusChangeRequestNotification message.|The rejection of a request to change the status of a transaction can be achieved by sending a StatusChangeRequestRejection message.")]
public partial record StatusChangeRequestAcceptanceV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReqAccptnc";
    
    #nullable enable
    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_v33NaNE8Ed-BzquC8wXy7w_-1262525650")]
    [Description(@"Identifies the acceptance message.")]
    [DataMember(Name="AccptncId")]
    [XmlElement(ElementName="AccptncId")]
    [Required]
    public required MessageIdentification1 AcceptanceIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_v33NadE8Ed-BzquC8wXy7w_-1262525622")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_v33NatE8Ed-BzquC8wXy7w_-1262525591")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Specifies the status accepted.
    /// </summary>
    [IsoId("_v33Na9E8Ed-BzquC8wXy7w_-1262525560")]
    [Description(@"Specifies the status accepted.")]
    [DataMember(Name="AccptdSts")]
    [XmlElement(ElementName="AccptdSts")]
    [Required]
    public required TransactionStatus3 AcceptedStatus { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusChangeRequestAcceptanceV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusChangeRequestAcceptanceV02Document ToDocument()
    {
        return new StatusChangeRequestAcceptanceV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusChangeRequestAcceptanceV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusChangeRequestAcceptanceV02Document : IOuterDocument<StatusChangeRequestAcceptanceV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.027.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusChangeRequestAcceptanceV02"/> is required.
    /// </summary>
    public required StatusChangeRequestAcceptanceV02 Message { get; init; }
}
