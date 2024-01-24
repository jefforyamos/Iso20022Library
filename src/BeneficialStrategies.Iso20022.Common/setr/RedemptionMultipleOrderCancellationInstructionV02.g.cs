﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionMultipleOrderCancellationInstructionV02.  ISO2002 ID# _q0U3iNE7Ed-BzquC8wXy7w_-953271126.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The RedemptionMultipleOrderCancellationInstruction message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is sent to cancel a previously sent RedemptionMultipleOrder instruction.
/// Usage
/// The RedemptionMultipleOrderCancellationInstruction message is used to cancel the entire previously sent RedemptionMultipleOrder message and all the individual orders that it contained. There is no amendment, but a cancellation and re-instruct policy.
/// This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.
/// The deadline and acceptance of a cancellation instruction is subject to a service level agreement (SLA). This cancellation message is a cancellation instruction. There is no automatic acceptance of the cancellation instruction.
/// The rejection or acceptance of a cancellation message instruction is made using an OrderCancellationStatusReport message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RedemptionMultipleOrderCancellationInstruction message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is sent to cancel a previously sent RedemptionMultipleOrder instruction.|Usage|The RedemptionMultipleOrderCancellationInstruction message is used to cancel the entire previously sent RedemptionMultipleOrder message and all the individual orders that it contained. There is no amendment, but a cancellation and re-instruct policy.|This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.|The deadline and acceptance of a cancellation instruction is subject to a service level agreement (SLA). This cancellation message is a cancellation instruction. There is no automatic acceptance of the cancellation instruction.|The rejection or acceptance of a cancellation message instruction is made using an OrderCancellationStatusReport message.")]
public partial record RedemptionMultipleOrderCancellationInstructionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.005.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionMultipleOrderCancellationInstructionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionMultipleOrderCancellationInstructionV02Document ToDocument()
    {
        return new RedemptionMultipleOrderCancellationInstructionV02Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The RedemptionMultipleOrderCancellationInstruction message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is sent to cancel a previously sent RedemptionMultipleOrder instruction.
/// Usage
/// The RedemptionMultipleOrderCancellationInstruction message is used to cancel the entire previously sent RedemptionMultipleOrder message and all the individual orders that it contained. There is no amendment, but a cancellation and re-instruct policy.
/// This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.
/// The deadline and acceptance of a cancellation instruction is subject to a service level agreement (SLA). This cancellation message is a cancellation instruction. There is no automatic acceptance of the cancellation instruction.
/// The rejection or acceptance of a cancellation message instruction is made using an OrderCancellationStatusReport message.
/// This is the outer document that contains <seealso cref="RedemptionMultipleOrderCancellationInstructionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionMultipleOrderCancellationInstructionV02Document : IOuterDocument<RedemptionMultipleOrderCancellationInstructionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionMultipleOrderCancellationInstructionV02"/> is required.
    /// </summary>
    public required RedemptionMultipleOrderCancellationInstructionV02 Message { get; init; }
}
