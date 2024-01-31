﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusChangeRequestNotificationV03.  ISO2002 ID# _wSYmONE8Ed-BzquC8wXy7w_439569273.
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
/// The StatusChangeRequestNotification message is sent by the matching application to the party requested to accept or reject the request of a change in the status of a transaction.
/// This message is used to notify the request of a change in the status of a transaction.
/// Usage
/// The StatusChangeRequestNotification message can be sent by the matching application to pass on the information about the request of a change in the status of a transaction that it has obtained through the receipt of a StatusChangeRequest message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusChangeRequestNotification message is sent by the matching application to the party requested to accept or reject the request of a change in the status of a transaction.|This message is used to notify the request of a change in the status of a transaction.|Usage|The StatusChangeRequestNotification message can be sent by the matching application to pass on the information about the request of a change in the status of a transaction that it has obtained through the receipt of a StatusChangeRequest message.")]
public partial record StatusChangeRequestNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReqNtfctn";
    
    #nullable enable
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_wSiXMNE8Ed-BzquC8wXy7w_439570377")]
    [Description(@"Identifies the notification message.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    [Required]
    public required MessageIdentification1 NotificationIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_wSiXMdE8Ed-BzquC8wXy7w_439570119")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_wSiXMtE8Ed-BzquC8wXy7w_439570205")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_wSiXM9E8Ed-BzquC8wXy7w_439569698")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    [Required]
    public required TransactionStatus4 TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_wSiXNNE8Ed-BzquC8wXy7w_439569386")]
    [Description(@"Reference to the transaction for each financial institution which is a party to the transaction.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required IReadOnlyCollection<DocumentIdentification5> UserTransactionReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Specifies the status that is proposed by the other party.
    /// </summary>
    [IsoId("_wSiXNdE8Ed-BzquC8wXy7w_439569777")]
    [Description(@"Specifies the status that is proposed by the other party.")]
    [DataMember(Name="PropsdStsChng")]
    [XmlElement(ElementName="PropsdStsChng")]
    [Required]
    public required TransactionStatus3 ProposedStatusChange { get; init; }
    
    /// <summary>
    /// Specifies the reason for the request to change status.
    /// </summary>
    [IsoId("_wSiXNtE8Ed-BzquC8wXy7w_439570689")]
    [Description(@"Specifies the reason for the request to change status.")]
    [DataMember(Name="ReqRsn")]
    [XmlElement(ElementName="ReqRsn")]
    public Reason2? RequestReason { get; init; }
    
    /// <summary>
    /// Party that has requested the status change.
    /// </summary>
    [IsoId("_wSiXN9E8Ed-BzquC8wXy7w_1643841205")]
    [Description(@"Party that has requested the status change.")]
    [DataMember(Name="Initr")]
    [XmlElement(ElementName="Initr")]
    [Required]
    public required BICIdentification1 Initiator { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_wSiXONE8Ed-BzquC8wXy7w_439569309")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusChangeRequestNotificationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusChangeRequestNotificationV03Document ToDocument()
    {
        return new StatusChangeRequestNotificationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusChangeRequestNotificationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusChangeRequestNotificationV03Document : IOuterDocument<StatusChangeRequestNotificationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.028.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusChangeRequestNotificationV03"/> is required.
    /// </summary>
    public required StatusChangeRequestNotificationV03 Message { get; init; }
}
