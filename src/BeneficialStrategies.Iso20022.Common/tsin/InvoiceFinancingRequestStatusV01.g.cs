﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InvoiceFinancingRequestStatusV01.  ISO2002 ID# _BUZXMH1LEeCF8NjrBemJWQ_1543411923.
//
namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// Scope
/// The InvoiceFinancingRequestStatus message is sent by the First Agent to the Financing Requestor, alternatively through an Intermediary Agent (relay scenario). It is used to inform the Financing Requestor about the positive or negative status of a financing request or a financing cancellation request.
/// Usage
/// The InvoiceFinancingRequestStatus message flows from the First Agent to the Financing Requestor (alternatively through an Intermediary Agent) to provide status information about a request previously sent.
/// Its usage will always be governed by a bilateral agreement between the First Agent and the Financing Requestor.
/// The InvoiceFinancingRequestStatus message can be used two fold:
/// - to provide information about the reception status (eg rejection, acceptance) of a request message. In this case the status message is the result of a technical validation performed by the First Agent on the request message received;
/// - to inform the Financing Requestor about the business status of the financing process initiated. In this case the First Agent can:
/// * communicate that a single financing request has been granted, is pending or has not been granted at all;
/// * inform that a financing cancellation request has been allowed or denied.
/// Note.
/// If the Financing Requestor requests financing for more than one instalment related to the same invoice, the First Agent can decide to finance only some of the instalments. In such case the status message contains details and status of every single instalment (financed, not financed).
/// The message can be used in a direct or in a relay scenario:
/// - In a direct scenario, the message is sent directly by the First Agent to the Financing Requestor;
/// - In a relay scenario, the message is sent first by the First Agent to the Intermediary Agent, who forwards it to the Financing Requestor.
/// The InvoiceFinancingRequestStatus message refers to the original request(s) by means of references and a set of data elements included into the original request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The InvoiceFinancingRequestStatus message is sent by the First Agent to the Financing Requestor, alternatively through an Intermediary Agent (relay scenario). It is used to inform the Financing Requestor about the positive or negative status of a financing request or a financing cancellation request.|Usage|The InvoiceFinancingRequestStatus message flows from the First Agent to the Financing Requestor (alternatively through an Intermediary Agent) to provide status information about a request previously sent.|Its usage will always be governed by a bilateral agreement between the First Agent and the Financing Requestor.|The InvoiceFinancingRequestStatus message can be used two fold:|- to provide information about the reception status (eg rejection, acceptance) of a request message. In this case the status message is the result of a technical validation performed by the First Agent on the request message received;|- to inform the Financing Requestor about the business status of the financing process initiated. In this case the First Agent can:|* communicate that a single financing request has been granted, is pending or has not been granted at all;|* inform that a financing cancellation request has been allowed or denied.|Note.|If the Financing Requestor requests financing for more than one instalment related to the same invoice, the First Agent can decide to finance only some of the instalments. In such case the status message contains details and status of every single instalment (financed, not financed).|The message can be used in a direct or in a relay scenario:|- In a direct scenario, the message is sent directly by the First Agent to the Financing Requestor;|- In a relay scenario, the message is sent first by the First Agent to the Intermediary Agent, who forwards it to the Financing Requestor.|The InvoiceFinancingRequestStatus message refers to the original request(s) by means of references and a set of data elements included into the original request.")]
public partial record InvoiceFinancingRequestStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcFincgReqSts";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// General information that unambiguously identify the invoice financing status report, such as status identification, creation date time.
    /// </summary>
    [IsoId("_BUZXMX1LEeCF8NjrBemJWQ_746296789")]
    [Description(@"General information that unambiguously identify the invoice financing status report, such as status identification, creation date time.")]
    [DataMember(Name="StsId")]
    [XmlElement(ElementName="StsId")]
    [Required]
    public required SomeStatusIdentificationRecord StatusIdentification { get; init; }
    
    /// <summary>
    /// Set of summary information that unambiguously identifies the original invoice financing (or cancellation) request to which the status is referred. The status of the original request is also given in this block.|.
    /// </summary>
    [IsoId("_BUZXMn1LEeCF8NjrBemJWQ_1550684151")]
    [Description(@"Set of summary information that unambiguously identifies the original invoice financing (or cancellation) request to which the status is referred. The status of the original request is also given in this block.|.")]
    [DataMember(Name="OrgnlReqInfAndSts")]
    [XmlElement(ElementName="OrgnlReqInfAndSts")]
    [Required]
    public required SomeOriginalRequestInformationAndStatusRecord OriginalRequestInformationAndStatus { get; init; }
    
    /// <summary>
    /// Information concerning the business status of a financing request.
    /// </summary>
    [IsoId("_BUZXM31LEeCF8NjrBemJWQ_740712719")]
    [Description(@"Information concerning the business status of a financing request.")]
    [DataMember(Name="FincgInfAndSts")]
    [XmlElement(ElementName="FincgInfAndSts")]
    public SomeFinancingInformationAndStatusRecord? FinancingInformationAndStatus { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InvoiceFinancingRequestStatusV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InvoiceFinancingRequestStatusV01Document ToDocument()
    {
        return new InvoiceFinancingRequestStatusV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InvoiceFinancingRequestStatusV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InvoiceFinancingRequestStatusV01Document : IOuterDocument<InvoiceFinancingRequestStatusV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InvoiceFinancingRequestStatusV01"/> is required.
    /// </summary>
    public required InvoiceFinancingRequestStatusV01 Message { get; init; }
}
