﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InvoiceTaxReportStatusAdviceV01.  ISO2002 ID# _HjF1skshEeWvyKllQkSXyA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The InvoiceTaxReportStatusAdvice message is sent by the matching application to the party from which it received a message.
/// This message is used to acknowledge the InvoiceTaxReport message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The InvoiceTaxReportStatusAdvice message is sent by the matching application to the party from which it received a message.|This message is used to acknowledge the InvoiceTaxReport message.")]
public partial record InvoiceTaxReportStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcTaxRptStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides the status on the InvoiceTaxReport.
    /// </summary>
    [IsoId("_uitmYE53Eeaine-lsNAGsA")]
    [Description(@"Provides the status on the InvoiceTaxReport.")]
    [DataMember(Name="StsRptHdr")]
    [XmlElement(ElementName="StsRptHdr")]
    [Required]
    public required SomeStatusReportHeaderRecord StatusReportHeader { get; init; }
    
    /// <summary>
    /// Provides the status on an individual transaction and the related reason if required.
    /// </summary>
    [IsoId("_PM8n8E54Eeaine-lsNAGsA")]
    [Description(@"Provides the status on an individual transaction and the related reason if required.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    public SomeTransactionStatusRecord? TransactionStatus { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific
    /// block.
    /// </summary>
    [IsoId("_XlusIE2ZEea-HpmqkM55Lg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific|block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InvoiceTaxReportStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InvoiceTaxReportStatusAdviceV01Document ToDocument()
    {
        return new InvoiceTaxReportStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InvoiceTaxReportStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InvoiceTaxReportStatusAdviceV01Document : IOuterDocument<InvoiceTaxReportStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.038.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InvoiceTaxReportStatusAdviceV01"/> is required.
    /// </summary>
    public required InvoiceTaxReportStatusAdviceV01 Message { get; init; }
}
