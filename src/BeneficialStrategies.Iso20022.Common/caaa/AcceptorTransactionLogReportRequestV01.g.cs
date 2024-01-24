﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorTransactionLogReportRequestV01.  ISO2002 ID# _KHcMgFSwEeuUvsVXOV79DQ.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorTransactionLogReportRequest message is sent by an Acceptor to an Acquirer or its IntermediaryAgent to request a report service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorTransactionLogReportRequest message is sent by an Acceptor to an Acquirer or its IntermediaryAgent to request a report service.")]
public partial record AcceptorTransactionLogReportRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrTxLgRptReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_F3SJcFSxEeuUvsVXOV79DQ")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the report request.
    /// </summary>
    [IsoId("_Vbe3IFSxEeuUvsVXOV79DQ")]
    [Description(@"Information related to the report request.")]
    [DataMember(Name="RptReq")]
    [XmlElement(ElementName="RptReq")]
    [Required]
    public required SomeReportRequestRecord ReportRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_kGn14FSxEeuUvsVXOV79DQ")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorTransactionLogReportRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorTransactionLogReportRequestV01Document ToDocument()
    {
        return new AcceptorTransactionLogReportRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorTransactionLogReportRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorTransactionLogReportRequestV01Document : IOuterDocument<AcceptorTransactionLogReportRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.024.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorTransactionLogReportRequestV01"/> is required.
    /// </summary>
    public required AcceptorTransactionLogReportRequestV01 Message { get; init; }
}
