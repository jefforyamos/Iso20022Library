﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TimeOutNotificationV03.  ISO2002 ID# _1eFPCNE8Ed-BzquC8wXy7w_1723275077.
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
/// The TimeOutNotification message is sent by the matching application to a party involved in a transaction.
/// This message is used to inform that a transaction will be closed within a given span of time if no action is taken.
/// Usage
/// The TimeOutNotification message can be sent by the matching application to inform the parties that a transaction will be closed within a given span of time if no action is taken by either party because
/// - no activity for the transaction has taken place within a specified span of time,or
/// - a significant date is reached, for example latest shipment date.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The TimeOutNotification message is sent by the matching application to a party involved in a transaction.|This message is used to inform that a transaction will be closed within a given span of time if no action is taken.|Usage|The TimeOutNotification message can be sent by the matching application to inform the parties that a transaction will be closed within a given span of time if no action is taken by either party because|- no activity for the transaction has taken place within a specified span of time,or|- a significant date is reached, for example latest shipment date.")]
public partial record TimeOutNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TmOutNtfctn";
    
    #nullable enable
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_1ePAANE8Ed-BzquC8wXy7w_1723275540")]
    [Description(@"Identifies the notification message.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    [Required]
    public required MessageIdentification1 NotificationIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_1ePAAdE8Ed-BzquC8wXy7w_1723275201")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_1ePAAtE8Ed-BzquC8wXy7w_1723275262")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_1ePAA9E8Ed-BzquC8wXy7w_1723275088")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    [Required]
    public required TransactionStatus4 TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_1ePABNE8Ed-BzquC8wXy7w_1723275231")]
    [Description(@"Reference to the transaction for each financial institution which is a party to the transaction.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required IReadOnlyCollection<DocumentIdentification5> UserTransactionReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Describes the time-out consequences.
    /// </summary>
    [IsoId("_1ePABdE8Ed-BzquC8wXy7w_1723275139")]
    [Description(@"Describes the time-out consequences.")]
    [DataMember(Name="TmOutDesc")]
    [XmlElement(ElementName="TmOutDesc")]
    [Required]
    public required TimeOutResult2 TimeOutDescription { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_1ePABtE8Ed-BzquC8wXy7w_1723275170")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TimeOutNotificationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TimeOutNotificationV03Document ToDocument()
    {
        return new TimeOutNotificationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TimeOutNotificationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TimeOutNotificationV03Document : IOuterDocument<TimeOutNotificationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.040.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TimeOutNotificationV03"/> is required.
    /// </summary>
    public required TimeOutNotificationV03 Message { get; init; }
}
