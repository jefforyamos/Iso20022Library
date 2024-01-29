﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InvoiceAssignmentRequestV01.  ISO2002 ID# _OTgzNDQy-AOSNFX-8224505.
//
namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// The InvoiceAssignmentRequest message is sent from a factoring client to a factoring service provider and, optionally, to an interested party. It indicates the transfer of payment obligations concerning financial documents.
/// The message contains a list of financing requests together with data that are necessary to transfer the related rights for example regarding legal references for example jurisdiction, language or country. Furthermore, the message can reference related messages and can include data from other messages.
/// A factoring client combines a set of financial documents with same characteristics and assigns them to a factoring service. The client can send several assignments in one message and combine them according to different criteria for example for different clients or different currencies.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The InvoiceAssignmentRequest message is sent from a factoring client to a factoring service provider and, optionally, to an interested party. It indicates the transfer of payment obligations concerning financial documents.|The message contains a list of financing requests together with data that are necessary to transfer the related rights for example regarding legal references for example jurisdiction, language or country. Furthermore, the message can reference related messages and can include data from other messages.|A factoring client combines a set of financial documents with same characteristics and assigns them to a factoring service. The client can send several assignments in one message and combine them according to different criteria for example for different clients or different currencies.")]
public partial record InvoiceAssignmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcAssgnmtReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics that unambiguously identify the invoice assigment request, such as group identification, creation date time, number of single invoice financing requests, totals and subtotals.
    /// </summary>
    [IsoId("_OTgzNDQz-AOSNFX-8224505")]
    [Description(@"Set of characteristics that unambiguously identify the invoice assigment request, such as group identification, creation date time, number of single invoice financing requests, totals and subtotals.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// List of assignments of financial items.
    /// </summary>
    [IsoId("_OTgzNDQ0-AOSNFX-8224505")]
    [Description(@"List of assignments of financial items.")]
    [DataMember(Name="AssgnmtList")]
    [XmlElement(ElementName="AssgnmtList")]
    [Required]
    public required SomeAssignmentListRecord AssignmentList { get; init; }
    
    /// <summary>
    /// Number of assignments.
    /// </summary>
    [IsoId("_OTgzNDQ1-AOSNFX-8224505")]
    [Description(@"Number of assignments.")]
    [DataMember(Name="AssgnmtCnt")]
    [XmlElement(ElementName="AssgnmtCnt")]
    public SomeAssignmentCountRecord? AssignmentCount { get; init; }
    
    /// <summary>
    /// Total number of individual items in all assignments.
    /// </summary>
    [IsoId("_OTgzNDQ2-AOSNFX-8224505")]
    [Description(@"Total number of individual items in all assignments.")]
    [DataMember(Name="ItmCnt")]
    [XmlElement(ElementName="ItmCnt")]
    public SomeItemCountRecord? ItemCount { get; init; }
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDQ3-AOSNFX-8224505")]
    [Description(@"Total of all individual amounts included in all lists, irrespective of currencies or direction.")]
    [DataMember(Name="CtrlSum")]
    [XmlElement(ElementName="CtrlSum")]
    public SomeControlSumRecord? ControlSum { get; init; }
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDQ4-AOSNFX-8224505")]
    [Description(@"Referenced or related business message.")]
    [DataMember(Name="AttchdMsg")]
    [XmlElement(ElementName="AttchdMsg")]
    public SomeAttachedMessageRecord? AttachedMessage { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InvoiceAssignmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InvoiceAssignmentRequestV01Document ToDocument()
    {
        return new InvoiceAssignmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InvoiceAssignmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InvoiceAssignmentRequestV01Document : IOuterDocument<InvoiceAssignmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.006.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InvoiceAssignmentRequestV01"/> is required.
    /// </summary>
    public required InvoiceAssignmentRequestV01 Message { get; init; }
}