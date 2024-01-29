﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MisMatchRejectionNotificationV03.  ISO2002 ID# _sB1-GNE8Ed-BzquC8wXy7w_-1828586196.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The MisMatchRejectionNotification message is sent by the matching application to the parties involved in the transaction.
/// This message is used to notify the rejection of mis-matched data sets.
/// Usage
/// The MisMatchRejectionNotification message can be sent by the matching application to pass on the information about the rejection of mis-matched data sets that it has obtained through the receipt of an MisMatchRejection message.
/// In order to pass on information about the acceptance of mis-matched data sets the matching application sends an MisMatchAcceptanceNotification message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MisMatchRejectionNotification message is sent by the matching application to the parties involved in the transaction.|This message is used to notify the rejection of mis-matched data sets.|Usage|The MisMatchRejectionNotification message can be sent by the matching application to pass on the information about the rejection of mis-matched data sets that it has obtained through the receipt of an MisMatchRejection message.|In order to pass on information about the acceptance of mis-matched data sets the matching application sends an MisMatchAcceptanceNotification message.")]
public partial record MisMatchRejectionNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MisMtchRjctnNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_sB1-GdE8Ed-BzquC8wXy7w_-1828585825")]
    [Description(@"Identifies the notification message.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    [Required]
    public required SomeNotificationIdentificationRecord NotificationIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_sB1-GtE8Ed-BzquC8wXy7w_-1828586193")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_sB1-G9E8Ed-BzquC8wXy7w_-1828586103")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    [Required]
    public required SomeEstablishedBaselineIdentificationRecord EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_sB_vENE8Ed-BzquC8wXy7w_-1828586134")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    [Required]
    public required SomeTransactionStatusRecord TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_sB_vEdE8Ed-BzquC8wXy7w_-1828585771")]
    [Description(@"Reference to the transaction for each financial institution which is a party to the transaction.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required IReadonlyCollection<SomeUserTransactionReferenceRecord> UserTransactionReference { get; init; } // Min=0, Max=2
    
    /// <summary>
    /// Reference to the identification of the report that contained the difference.
    /// </summary>
    [IsoId("_sB_vEtE8Ed-BzquC8wXy7w_-1828585794")]
    [Description(@"Reference to the identification of the report that contained the difference.")]
    [DataMember(Name="DataSetMtchRptRef")]
    [XmlElement(ElementName="DataSetMtchRptRef")]
    [Required]
    public required SomeDataSetMatchReportReferenceRecord DataSetMatchReportReference { get; init; }
    
    /// <summary>
    /// Specifies the reaons for rejecting the mismatch.
    /// </summary>
    [IsoId("_sB_vE9E8Ed-BzquC8wXy7w_-1828585709")]
    [Description(@"Specifies the reaons for rejecting the mismatch.")]
    [DataMember(Name="RjctnRsn")]
    [XmlElement(ElementName="RjctnRsn")]
    [Required]
    public required SomeRejectionReasonRecord RejectionReason { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_sB_vFNE8Ed-BzquC8wXy7w_-1828585679")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public SomeRequestForActionRecord? RequestForAction { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MisMatchRejectionNotificationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MisMatchRejectionNotificationV03Document ToDocument()
    {
        return new MisMatchRejectionNotificationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MisMatchRejectionNotificationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MisMatchRejectionNotificationV03Document : IOuterDocument<MisMatchRejectionNotificationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.023.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MisMatchRejectionNotificationV03"/> is required.
    /// </summary>
    public required MisMatchRejectionNotificationV03 Message { get; init; }
}