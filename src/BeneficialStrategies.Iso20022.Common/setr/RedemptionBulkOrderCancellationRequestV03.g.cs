﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionBulkOrderCancellationRequestV03.  ISO2002 ID# _nuu_m9E7Ed-BzquC8wXy7w_-424280902.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the RedemptionBulkOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent RedemptionBulkOrder instruction.
/// Usage
/// The RedemptionBulkOrderCancellationRequest message is used to either:
/// - request the cancellation of an entire RedemptionBulkOrder message, that is, all the individual orders that it contained, or,
/// - request the cancellation of one or more individual orders included in a previously sent RedemptionBulkOrder message. There is no amendment, but a cancellation and re-instruct policy.
/// There are two ways to use the message.
/// (1) When the RedemptionBulkOrderCancellationRequest message is used to request the cancellation of an entire RedemptionBulkOrder message, this can be done by either:
/// - quoting the order references of all the individual orders listed in the RedemptionBulkOrder message, or,
/// - quoting the details of all the individual orders (this includes the OrderReference) listed in RedemptionBulkOrder message, but this is not recommended.
/// The message identification of the RedemptionBulkOrder message may also be quoted in PreviousReference.
/// It is also possible to request the cancellation of an entire RedemptionBulkOrder message by quoting its message identification in PreviousReference, but this is not recommended.
/// (2) When the RedemptionBulkOrderCancellationRequest message is used to request the cancellation of one or more individual orders, this can be done by either:
/// - quoting the OrderReference of each individual order listed in the RedemptionOrder message, or,
/// - quoting the details of each individual order (including the OrderReference) listed in RedemptionOrder message, but this is not recommended.
/// The message identification of the RedemptionBulkOrder message in which the individual order was conveyed may also be quoted in PreviousReference.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the RedemptionBulkOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent RedemptionBulkOrder instruction.|Usage|The RedemptionBulkOrderCancellationRequest message is used to either:|- request the cancellation of an entire RedemptionBulkOrder message, that is, all the individual orders that it contained, or,|- request the cancellation of one or more individual orders included in a previously sent RedemptionBulkOrder message. There is no amendment, but a cancellation and re-instruct policy.|There are two ways to use the message.|(1) When the RedemptionBulkOrderCancellationRequest message is used to request the cancellation of an entire RedemptionBulkOrder message, this can be done by either:|- quoting the order references of all the individual orders listed in the RedemptionBulkOrder message, or,|- quoting the details of all the individual orders (this includes the OrderReference) listed in RedemptionBulkOrder message, but this is not recommended.|The message identification of the RedemptionBulkOrder message may also be quoted in PreviousReference.|It is also possible to request the cancellation of an entire RedemptionBulkOrder message by quoting its message identification in PreviousReference, but this is not recommended.|(2) When the RedemptionBulkOrderCancellationRequest message is used to request the cancellation of one or more individual orders, this can be done by either:|- quoting the OrderReference of each individual order listed in the RedemptionOrder message, or,|- quoting the details of each individual order (including the OrderReference) listed in RedemptionOrder message, but this is not recommended.|The message identification of the RedemptionBulkOrder message in which the individual order was conveyed may also be quoted in PreviousReference.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.")]
public partial record RedemptionBulkOrderCancellationRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedBlkOrdrCxlReqV03";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionBulkOrderCancellationRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionBulkOrderCancellationRequestV03Document ToDocument()
    {
        return new RedemptionBulkOrderCancellationRequestV03Document { Message = this };
    }
}

/// <summary>
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the RedemptionBulkOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent RedemptionBulkOrder instruction.
/// Usage
/// The RedemptionBulkOrderCancellationRequest message is used to either:
/// - request the cancellation of an entire RedemptionBulkOrder message, that is, all the individual orders that it contained, or,
/// - request the cancellation of one or more individual orders included in a previously sent RedemptionBulkOrder message. There is no amendment, but a cancellation and re-instruct policy.
/// There are two ways to use the message.
/// (1) When the RedemptionBulkOrderCancellationRequest message is used to request the cancellation of an entire RedemptionBulkOrder message, this can be done by either:
/// - quoting the order references of all the individual orders listed in the RedemptionBulkOrder message, or,
/// - quoting the details of all the individual orders (this includes the OrderReference) listed in RedemptionBulkOrder message, but this is not recommended.
/// The message identification of the RedemptionBulkOrder message may also be quoted in PreviousReference.
/// It is also possible to request the cancellation of an entire RedemptionBulkOrder message by quoting its message identification in PreviousReference, but this is not recommended.
/// (2) When the RedemptionBulkOrderCancellationRequest message is used to request the cancellation of one or more individual orders, this can be done by either:
/// - quoting the OrderReference of each individual order listed in the RedemptionOrder message, or,
/// - quoting the details of each individual order (including the OrderReference) listed in RedemptionOrder message, but this is not recommended.
/// The message identification of the RedemptionBulkOrder message in which the individual order was conveyed may also be quoted in PreviousReference.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// This is the outer document that contains <seealso cref="RedemptionBulkOrderCancellationRequestV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionBulkOrderCancellationRequestV03Document : IOuterDocument<RedemptionBulkOrderCancellationRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.002.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionBulkOrderCancellationRequestV03"/> is required.
    /// </summary>
    public required RedemptionBulkOrderCancellationRequestV03 Message { get; init; }
}
