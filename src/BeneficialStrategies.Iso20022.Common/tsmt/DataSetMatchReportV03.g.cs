﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DataSetMatchReportV03.  ISO2002 ID# _m1ZuaNE8Ed-BzquC8wXy7w_-439674056.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The DataSetMatchReport message is sent by the matching application to the parties involved in a data set match.
/// This message is used to either
/// - inform about the successful match of data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline,or
/// - inform about mis-matches found between data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline.
/// Usage
/// The DataSetMatchReport message can be sent by the matching application to the party requesting a data set pre-match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful pre-match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.
/// or
/// The DataSetMatchReport message can be sent by the matching application to the parties involved in a data set match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.
/// or
/// The DataSetMatchReport message can be sent by the matching application to the party requesting a data set match or pre-match for a transaction established in the lodge mode. In the outlined scenario, the DataSetMatchReport will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The DataSetMatchReport message is sent by the matching application to the parties involved in a data set match.|This message is used to either|- inform about the successful match of data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline,or|- inform about mis-matches found between data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline.|Usage|The DataSetMatchReport message can be sent by the matching application to the party requesting a data set pre-match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful pre-match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.|or|The DataSetMatchReport message can be sent by the matching application to the parties involved in a data set match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.|or|The DataSetMatchReport message can be sent by the matching application to the party requesting a data set match or pre-match for a transaction established in the lodge mode. In the outlined scenario, the DataSetMatchReport will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.")]
public partial record DataSetMatchReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DataSetMtchRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_m1i4UNE8Ed-BzquC8wXy7w_-439673685")]
    [Description(@"Identifies the report.")]
    [DataMember(Name="RptId")]
    [XmlElement(ElementName="RptId")]
    [Required]
    public required SomeReportIdentificationRecord ReportIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_m1i4UdE8Ed-BzquC8wXy7w_-439673654")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_m1i4UtE8Ed-BzquC8wXy7w_-439673715")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    [Required]
    public required SomeEstablishedBaselineIdentificationRecord EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_m1i4U9E8Ed-BzquC8wXy7w_-439673623")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    [Required]
    public required SomeTransactionStatusRecord TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_m1i4VNE8Ed-BzquC8wXy7w_-439673775")]
    [Description(@"Reference to the transaction for each financial institution which is a party to the transaction.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required IReadonlyCollection<SomeUserTransactionReferenceRecord> UserTransactionReference { get; init; } // Min=0, Max=2
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_m1i4VdE8Ed-BzquC8wXy7w_-439673168")]
    [Description(@"Party that buys goods or services, or a financial instrument.")]
    [DataMember(Name="Buyr")]
    [XmlElement(ElementName="Buyr")]
    [Required]
    public required SomeBuyerRecord Buyer { get; init; }
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_m1i4VtE8Ed-BzquC8wXy7w_-439673229")]
    [Description(@"Party that sells goods or services, or a financial instrument.")]
    [DataMember(Name="Sellr")]
    [XmlElement(ElementName="Sellr")]
    [Required]
    public required SomeSellerRecord Seller { get; init; }
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_m1i4V9E8Ed-BzquC8wXy7w_-439673291")]
    [Description(@"The financial institution of the buyer, uniquely identified by its BIC.")]
    [DataMember(Name="BuyrBk")]
    [XmlElement(ElementName="BuyrBk")]
    [Required]
    public required SomeBuyerBankRecord BuyerBank { get; init; }
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_m1spUNE8Ed-BzquC8wXy7w_-439673345")]
    [Description(@"The financial institution of the seller, uniquely identified by its BIC.")]
    [DataMember(Name="SellrBk")]
    [XmlElement(ElementName="SellrBk")]
    [Required]
    public required SomeSellerBankRecord SellerBank { get; init; }
    
    /// <summary>
    /// Identifies the documents compared in this report.
    /// </summary>
    [IsoId("_m1spUdE8Ed-BzquC8wXy7w_-439674053")]
    [Description(@"Identifies the documents compared in this report.")]
    [DataMember(Name="CmpardDocRef")]
    [XmlElement(ElementName="CmpardDocRef")]
    public SomeComparedDocumentReferenceRecord? ComparedDocumentReference { get; init; } // WARNING: Cardinality could not be determined.
    
    /// <summary>
    /// Specifies whether the data set was submitted for match or pre-match.
    /// </summary>
    [IsoId("_m1spUtE8Ed-BzquC8wXy7w_-439673137")]
    [Description(@"Specifies whether the data set was submitted for match or pre-match.")]
    [DataMember(Name="SubmissnTp")]
    [XmlElement(ElementName="SubmissnTp")]
    [Required]
    public required SomeSubmissionTypeRecord SubmissionType { get; init; }
    
    /// <summary>
    /// Description of the differences between the data set(s) and the baseline.
    /// </summary>
    [IsoId("_m1spU9E8Ed-BzquC8wXy7w_-439674024")]
    [Description(@"Description of the differences between the data set(s) and the baseline.")]
    [DataMember(Name="Rpt")]
    [XmlElement(ElementName="Rpt")]
    [Required]
    public required SomeReportRecord Report { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_m1spVNE8Ed-BzquC8wXy7w_-439673260")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public SomeRequestForActionRecord? RequestForAction { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DataSetMatchReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DataSetMatchReportV03Document ToDocument()
    {
        return new DataSetMatchReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DataSetMatchReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DataSetMatchReportV03Document : IOuterDocument<DataSetMatchReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DataSetMatchReportV03"/> is required.
    /// </summary>
    public required DataSetMatchReportV03 Message { get; init; }
}
