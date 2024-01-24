﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for OrderConfirmationStatusReportV02.  ISO2002 ID# _Aab8NTbLEead9bDRE_1DAQ.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The OrderConfirmationStatusReport message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.
/// Usage
/// The OrderConfirmationStatusReport message is used to report on the status of one or more individual:
/// - subscription confirmations,
/// - subscription confirmation amendments,
/// - redemption confirmations,
/// - redemption confirmation amendments,
/// - switch order confirmations,
/// - switch order confirmation amendments.
/// One of the following statuses can be reported:
/// - confirmation rejected, or,
/// - amendment rejected, or,
/// - sent to next party, or,
/// - communication problem with next party, or,
/// - confirmation accepted, or,
/// - confirmation received.
/// It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.
/// If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.
/// The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The OrderConfirmationStatusReport message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.|Usage|The OrderConfirmationStatusReport message is used to report on the status of one or more individual:|- subscription confirmations,|- subscription confirmation amendments,|- redemption confirmations,|- redemption confirmation amendments,|- switch order confirmations,|- switch order confirmation amendments.|One of the following statuses can be reported:|- confirmation rejected, or,|- amendment rejected, or,|- sent to next party, or,|- communication problem with next party, or,|- confirmation accepted, or,|- confirmation received.|It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.|If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.|The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended.")]
public partial record OrderConfirmationStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "OrdrConfStsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab8PTbLEead9bDRE_1DAQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_JkdC0EhAEea8pJjypp-yMQ")]
    [Description(@"Reference to the message or communication that was previously received.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    public SomeReferenceRecord? Reference { get; init; }
    
    /// <summary>
    /// Status report details of an individual order confirmation.
    /// </summary>
    [IsoId("_Aab8QzbLEead9bDRE_1DAQ")]
    [Description(@"Status report details of an individual order confirmation.")]
    [DataMember(Name="IndvOrdrConfDtlsRpt")]
    [XmlElement(ElementName="IndvOrdrConfDtlsRpt")]
    [Required]
    public required SomeIndividualOrderConfirmationDetailsReportRecord IndividualOrderConfirmationDetailsReport { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab8RTbLEead9bDRE_1DAQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="OrderConfirmationStatusReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public OrderConfirmationStatusReportV02Document ToDocument()
    {
        return new OrderConfirmationStatusReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="OrderConfirmationStatusReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record OrderConfirmationStatusReportV02Document : IOuterDocument<OrderConfirmationStatusReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.057.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="OrderConfirmationStatusReportV02"/> is required.
    /// </summary>
    public required OrderConfirmationStatusReportV02 Message { get; init; }
}
