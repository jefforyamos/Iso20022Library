﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for OrderCancellationStatusReportV04.  ISO2002 ID# _Aab7PTbLEead9bDRE_1DAQ.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The OrderCancellationStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to report the status of an order cancellation request that was previously received.
/// Usage
/// The OrderCancellationStatusReport message is used to provide the status of:
/// - one or more individual order cancellation requests by using IndividualCancellationStatusReport, or,
/// - an order cancellation request message by using CancellationStatusReport.
/// If the OrderCancellationStatusReport message is used to report the status of an individual order cancellation request, then the repetitive IndividualCancellationStatusReport sequence is used and the order reference of the individual order is quoted in OrderReference. The message identification of the message in which the individual order was conveyed may also be quoted in RelatedReference but this is not recommended.
/// If the OrderCancellationStatusReport message is used to report the status of an entire order cancellation request message, for example, the SubscriptionBulkOrderCancellationRequest, or a SubscriptionOrderCancellationRequest containing several orders, then the CancellationStatusReport sequence is used. The message identification of the order cancellation request message may also be quoted in RelatedReference but this is not recommended. All the order cancellation requests within the message must have the same status.
/// One of the following statuses can be reported: 
/// - the order cancellation is pending, or,
/// - the order cancellation request is rejected, or,
/// - the order is cancelled.
/// When the cancellation is rejected, the reason for the rejection must be specified.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The OrderCancellationStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to report the status of an order cancellation request that was previously received.|Usage|The OrderCancellationStatusReport message is used to provide the status of:|- one or more individual order cancellation requests by using IndividualCancellationStatusReport, or,|- an order cancellation request message by using CancellationStatusReport.|If the OrderCancellationStatusReport message is used to report the status of an individual order cancellation request, then the repetitive IndividualCancellationStatusReport sequence is used and the order reference of the individual order is quoted in OrderReference. The message identification of the message in which the individual order was conveyed may also be quoted in RelatedReference but this is not recommended.|If the OrderCancellationStatusReport message is used to report the status of an entire order cancellation request message, for example, the SubscriptionBulkOrderCancellationRequest, or a SubscriptionOrderCancellationRequest containing several orders, then the CancellationStatusReport sequence is used. The message identification of the order cancellation request message may also be quoted in RelatedReference but this is not recommended. All the order cancellation requests within the message must have the same status.|One of the following statuses can be reported: |- the order cancellation is pending, or,|- the order cancellation request is rejected, or,|- the order is cancelled.|When the cancellation is rejected, the reason for the rejection must be specified.")]
public partial record OrderCancellationStatusReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "OrdrCxlStsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab7RzbLEead9bDRE_1DAQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_0TCgMUgqEeaD2L_hzZaE0w")]
    [Description(@"Reference to the message or communication that was previously received.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    public SomeReferenceRecord? Reference { get; init; }
    
    /// <summary>
    /// Status of the order cancellation.
    /// </summary>
    [IsoId("_HOh50EgrEeaD2L_hzZaE0w")]
    [Description(@"Status of the order cancellation.")]
    [DataMember(Name="StsRpt")]
    [XmlElement(ElementName="StsRpt")]
    [Required]
    public required SomeStatusReportRecord StatusReport { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab7UTbLEead9bDRE_1DAQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="OrderCancellationStatusReportV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public OrderCancellationStatusReportV04Document ToDocument()
    {
        return new OrderCancellationStatusReportV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="OrderCancellationStatusReportV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record OrderCancellationStatusReportV04Document : IOuterDocument<OrderCancellationStatusReportV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.017.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="OrderCancellationStatusReportV04"/> is required.
    /// </summary>
    public required OrderCancellationStatusReportV04 Message { get; init; }
}