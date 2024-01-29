﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for OrderCancellationStatusReportV02.  ISO2002 ID# _gilh-NE7Ed-BzquC8wXy7w_-1859459709.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The OrderCancellationStatusReport is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.
/// The message gives the status of an order cancellation instruction message that was previously sent by the instructing party.
/// Usage
/// The OrderCancellationStatusReport message is used to report the status of an order cancellation instruction message that was previously sent by the instructing party. The message can be used to report one of the following:
/// - the cancellation is accepted for further processing, or
/// - the cancellation is rejected, or
/// - the order has been cancelled.
/// When the cancellation is rejected, the reason for the rejection must be specified.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The OrderCancellationStatusReport is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.|The message gives the status of an order cancellation instruction message that was previously sent by the instructing party.|Usage|The OrderCancellationStatusReport message is used to report the status of an order cancellation instruction message that was previously sent by the instructing party. The message can be used to report one of the following:|- the cancellation is accepted for further processing, or|- the cancellation is rejected, or|- the order has been cancelled.|When the cancellation is rejected, the reason for the rejection must be specified.")]
public partial record OrderCancellationStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.017.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_gilh-dE7Ed-BzquC8wXy7w_339506897")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public required IReadonlyCollection<SomeRelatedReferenceRecord> RelatedReference { get; init; } // Min=1, Max=2
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_gilh-tE7Ed-BzquC8wXy7w_-1972675840")]
    [Description(@"Reference to a linked message sent in a proprietary way or reference of a system.")]
    [DataMember(Name="OthrRef")]
    [XmlElement(ElementName="OthrRef")]
    public required IReadonlyCollection<SomeOtherReferenceRecord> OtherReference { get; init; } // Min=1, Max=2
    
    /// <summary>
    /// Status report details of a bulk or multiple or switch order cancellation instruction that was previously received.
    /// </summary>
    [IsoId("_gilh-9E7Ed-BzquC8wXy7w_1147588729")]
    [Description(@"Status report details of a bulk or multiple or switch order cancellation instruction that was previously received.")]
    [DataMember(Name="CxlStsRpt")]
    [XmlElement(ElementName="CxlStsRpt")]
    [Required]
    public required SomeCancellationStatusReportRecord CancellationStatusReport { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="OrderCancellationStatusReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public OrderCancellationStatusReportV02Document ToDocument()
    {
        return new OrderCancellationStatusReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="OrderCancellationStatusReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record OrderCancellationStatusReportV02Document : IOuterDocument<OrderCancellationStatusReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.017.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="OrderCancellationStatusReportV02"/> is required.
    /// </summary>
    public required OrderCancellationStatusReportV02 Message { get; init; }
}