﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InvoiceFinancingRequestV01.  ISO2002 ID# _BU2DIH1LEeCF8NjrBemJWQ_-1652041162.
//
namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// Scope
/// The InvoiceFinancingRequest message is sent by Financing Requestor to the Intermediary Agent or First agent. It is used to request financing of a set of invoices, referenced in the request message itself. If the whole financing request (or a selection of single invoice requests included) is accepted, the amount financed by the First Agent will be credited either to the account specified in the financing request or to another account held by Financing Requestor to First Agent.
/// Usage
/// The InvoiceFinancingRequest message is issued by the Financing Requestor and represents a bulk financing request since it can contain one or more single financing requests, each request related to an invoice.
/// For every invoice it is always possible to identify a supplier and a buyer.
/// The subject playing the role of supplier can be different from the Financing Requestor; in this case the Financing Requestor is allowed to send the request message on behalf of the supplier itself.
/// This caters for example in the scenario of a collection agency initiating all requests on behalf of a large corporate.
/// In instances where an invoice is going to be paid by means of instalments, the Financing Requestor can request financing for one or more instalments related to the invoice payment. In this case, together with the general information related to the invoice, references about instalments to be financed are specified into the request message. The request message must contain information only about the instalments that the Financing Requestor wants to be financed.
/// The InvoiceFinancingRequest message is used to exchange:
/// - One instance of general information related to the invoice financing request;
/// - One instance of information for each single invoice financing request;
/// - Optionally, one instance of information for each single instalment to be financed.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the First Agent. The First Agent is the account servicer of the Financing Requestor;
/// - In a relay scenario, the message is sent to an Intermediary Agent. The Intermediary Agent acts as an access point that will forward the InvoiceFinancingRequest message to the First Agent.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The InvoiceFinancingRequest message is sent by Financing Requestor to the Intermediary Agent or First agent. It is used to request financing of a set of invoices, referenced in the request message itself. If the whole financing request (or a selection of single invoice requests included) is accepted, the amount financed by the First Agent will be credited either to the account specified in the financing request or to another account held by Financing Requestor to First Agent.|Usage|The InvoiceFinancingRequest message is issued by the Financing Requestor and represents a bulk financing request since it can contain one or more single financing requests, each request related to an invoice.|For every invoice it is always possible to identify a supplier and a buyer.|The subject playing the role of supplier can be different from the Financing Requestor; in this case the Financing Requestor is allowed to send the request message on behalf of the supplier itself.|This caters for example in the scenario of a collection agency initiating all requests on behalf of a large corporate.|In instances where an invoice is going to be paid by means of instalments, the Financing Requestor can request financing for one or more instalments related to the invoice payment. In this case, together with the general information related to the invoice, references about instalments to be financed are specified into the request message. The request message must contain information only about the instalments that the Financing Requestor wants to be financed.|The InvoiceFinancingRequest message is used to exchange:|- One instance of general information related to the invoice financing request;|- One instance of information for each single invoice financing request;|- Optionally, one instance of information for each single instalment to be financed.|The message can be used in a direct or a relay scenario:|- In a direct scenario, the message is sent directly to the First Agent. The First Agent is the account servicer of the Financing Requestor;|- In a relay scenario, the message is sent to an Intermediary Agent. The Intermediary Agent acts as an access point that will forward the InvoiceFinancingRequest message to the First Agent.")]
public partial record InvoiceFinancingRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcFincgReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Specifies a set of characteristics that unambiguously identify the invoice financing request, such as group identification, creation date time, number of single invoice financing requests.
    /// </summary>
    [IsoId("_BU2DIX1LEeCF8NjrBemJWQ_-1652041118")]
    [Description(@"Specifies a set of characteristics that unambiguously identify the invoice financing request, such as group identification, creation date time, number of single invoice financing requests.")]
    [DataMember(Name="ReqGrpInf")]
    [XmlElement(ElementName="ReqGrpInf")]
    [Required]
    public required SomeRequestGroupInformationRecord RequestGroupInformation { get; init; }
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the single invoice financing request related to the entire invoice or a specific instalment of the invoice settlement, such as actors involved, invoice totals or payment method.
    /// </summary>
    [IsoId("_BU2DIn1LEeCF8NjrBemJWQ_-1651121112")]
    [Description(@"Set of characteristics that unambiguously identify the single invoice financing request related to the entire invoice or a specific instalment of the invoice settlement, such as actors involved, invoice totals or payment method.")]
    [DataMember(Name="InvcReqInf")]
    [XmlElement(ElementName="InvcReqInf")]
    [Required]
    public required SomeInvoiceRequestInformationRecord InvoiceRequestInformation { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InvoiceFinancingRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InvoiceFinancingRequestV01Document ToDocument()
    {
        return new InvoiceFinancingRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InvoiceFinancingRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InvoiceFinancingRequestV01Document : IOuterDocument<InvoiceFinancingRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InvoiceFinancingRequestV01"/> is required.
    /// </summary>
    public required InvoiceFinancingRequestV01 Message { get; init; }
}