﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SpecialNotificationV01.  ISO2002 ID# _uldKWNE8Ed-BzquC8wXy7w_-3505275.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The SpecialNotification message is sent by the matching application to parties to the transaction, following the receipt of a SpecialRequest message.
/// The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.
/// Usage
/// The SpecialNotification message is sent to the parties to the transaction so that they can take appropriate action.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SpecialNotification message is sent by the matching application to parties to the transaction, following the receipt of a SpecialRequest message.|The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.|Usage|The SpecialNotification message is sent to the parties to the transaction so that they can take appropriate action.")]
public partial record SpecialNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SpclNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_ulm7UNE8Ed-BzquC8wXy7w_7576915")]
    [Description(@"Identifies the notification message.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    [Required]
    public required MessageIdentification1 NotificationIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_ulm7UdE8Ed-BzquC8wXy7w_8501968")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_ulm7UtE8Ed-BzquC8wXy7w_8499489")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    [Required]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_ulm7U9E8Ed-BzquC8wXy7w_8500107")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    [Required]
    public required TransactionStatus4 TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the financial institution that is the sender of the acknowledged message.
    /// </summary>
    [IsoId("_ulm7VNE8Ed-BzquC8wXy7w_8502400")]
    [Description(@"Reference to the transaction for the financial institution that is the sender of the acknowledged message.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required IReadonlyCollection<DocumentIdentification5> UserTransactionReference { get; init; } // Min=0, Max=2
    
    /// <summary>
    /// Party that has sent the special request.
    /// </summary>
    [IsoId("_ulm7VdE8Ed-BzquC8wXy7w_1354069290")]
    [Description(@"Party that has sent the special request.")]
    [DataMember(Name="Initr")]
    [XmlElement(ElementName="Initr")]
    [Required]
    public required BICIdentification1 Initiator { get; init; }
    
    /// <summary>
    /// Notification received by the matching application and forwarded to another party.
    /// </summary>
    [IsoId("_ulm7VtE8Ed-BzquC8wXy7w_1253406214")]
    [Description(@"Notification received by the matching application and forwarded to another party.")]
    [DataMember(Name="Ntfctn")]
    [XmlElement(ElementName="Ntfctn")]
    [Required]
    public required Notification1 Notification { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_ulm7V9E8Ed-BzquC8wXy7w_8500865")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SpecialNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SpecialNotificationV01Document ToDocument()
    {
        return new SpecialNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SpecialNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SpecialNotificationV01Document : IOuterDocument<SpecialNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.048.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SpecialNotificationV01"/> is required.
    /// </summary>
    public required SpecialNotificationV01 Message { get; init; }
}
