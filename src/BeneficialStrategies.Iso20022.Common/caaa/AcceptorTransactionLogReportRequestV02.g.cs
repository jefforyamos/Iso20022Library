﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorTransactionLogReportRequestV02.  ISO2002 ID# _L8IqIU6vEeyGi9JAv6wq7Q.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorTransactionLogReportRequest message is sent by an Acceptor to an Acquirer or its IntermediaryAgent to request a report service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorTransactionLogReportRequest message is sent by an Acceptor to an Acquirer or its IntermediaryAgent to request a report service.")]
public partial record AcceptorTransactionLogReportRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrTxLgRptReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorTransactionLogReportRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorTransactionLogReportRequestV02Document ToDocument()
    {
        return new AcceptorTransactionLogReportRequestV02Document { Message = this };
    }
}

/// <summary>
/// The AcceptorTransactionLogReportRequest message is sent by an Acceptor to an Acquirer or its IntermediaryAgent to request a report service.
/// This is the outer document that contains <seealso cref="AcceptorTransactionLogReportRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorTransactionLogReportRequestV02Document : IOuterDocument<AcceptorTransactionLogReportRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.024.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorTransactionLogReportRequestV02"/> is required.
    /// </summary>
    public required AcceptorTransactionLogReportRequestV02 Message { get; init; }
}
