﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferCancellationStatusReportV05.  ISO2002 ID# _LXmFER8OEeWpZde3LQh6dg.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An executing party, for example, a transfer agent, sends the TransferCancellationStatusReport message to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer cancellation instruction.
/// Usage
/// The TransferCancellationStatusReport message is used to report on the status of a transfer in or transfer out cancellation request.
/// The reference of the transfer instruction for which the cancellation status is reported is identified in TransferReference. The message identification of the transfer cancellation request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// The message identification of the transfer instruction request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// One of the following statuses can be reported:
/// - the transfer cancellation is accepted, or,
/// - the transfer cancellation has been sent to the next party, or,
/// - the transfer cancellation is complete and the reason for the status,
/// - the transfer cancellation pending and the reason for the status,
/// - the transfer cancellation is rejected and the reason for the status.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the TransferCancellationStatusReport message to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer cancellation instruction.|Usage|The TransferCancellationStatusReport message is used to report on the status of a transfer in or transfer out cancellation request.|The reference of the transfer instruction for which the cancellation status is reported is identified in TransferReference. The message identification of the transfer cancellation request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|The message identification of the transfer instruction request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|One of the following statuses can be reported:|- the transfer cancellation is accepted, or,|- the transfer cancellation has been sent to the next party, or,|- the transfer cancellation is complete and the reason for the status,|- the transfer cancellation pending and the reason for the status,|- the transfer cancellation is rejected and the reason for the status.")]
public partial record TransferCancellationStatusReportV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfCxlStsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_LXmFFx8OEeWpZde3LQh6dg")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_LXmFGR8OEeWpZde3LQh6dg")]
    [Description(@"Unambiguous identification of the transfer allocated by the counterparty.")]
    [DataMember(Name="CtrPtyRef")]
    [XmlElement(ElementName="CtrPtyRef")]
    public SomeCounterpartyReferenceRecord? CounterpartyReference { get; init; }
    
    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_LXmFGx8OEeWpZde3LQh6dg")]
    [Description(@"Reference to the message or communication that was previously received.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    public SomeReferenceRecord? Reference { get; init; }
    
    /// <summary>
    /// Status of the transfer cancellation instruction.
    /// </summary>
    [IsoId("_LXmFHR8OEeWpZde3LQh6dg")]
    [Description(@"Status of the transfer cancellation instruction.")]
    [DataMember(Name="StsRpt")]
    [XmlElement(ElementName="StsRpt")]
    [Required]
    public required SomeStatusReportRecord StatusReport { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_LXmFHx8OEeWpZde3LQh6dg")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public SomeMarketPracticeVersionRecord? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LXmFIR8OEeWpZde3LQh6dg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferCancellationStatusReportV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferCancellationStatusReportV05Document ToDocument()
    {
        return new TransferCancellationStatusReportV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferCancellationStatusReportV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferCancellationStatusReportV05Document : IOuterDocument<TransferCancellationStatusReportV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferCancellationStatusReportV05"/> is required.
    /// </summary>
    public required TransferCancellationStatusReportV05 Message { get; init; }
}