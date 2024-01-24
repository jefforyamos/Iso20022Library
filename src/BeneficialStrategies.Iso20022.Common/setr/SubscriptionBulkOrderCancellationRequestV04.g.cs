﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionBulkOrderCancellationRequestV04.  ISO2002 ID# _Aab6czbLEead9bDRE_1DAQ.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The SubscriptionBulkOrderCancellationRequest message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SubscriptionBulkOrder.
/// Usage
/// The SubscriptionBulkOrderCancellationRequest message is used to request the cancellation of one or more individual orders.
/// There is no amendment, but a cancellation and re-instruct policy.
/// To request the cancellation of one or more individual orders, the order reference of each individual order listed in the original SubscriptionBulkOrder message is specified in the order reference element. The message identification of the SubscriptionBulkOrder message which contains the individual orders to be cancelled may also be quoted in PreviousReference but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a SubscriptionBulkOrderCancellationRequest is made using an OrderCancellationStatusReport message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SubscriptionBulkOrderCancellationRequest message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SubscriptionBulkOrder.|Usage|The SubscriptionBulkOrderCancellationRequest message is used to request the cancellation of one or more individual orders.|There is no amendment, but a cancellation and re-instruct policy.|To request the cancellation of one or more individual orders, the order reference of each individual order listed in the original SubscriptionBulkOrder message is specified in the order reference element. The message identification of the SubscriptionBulkOrder message which contains the individual orders to be cancelled may also be quoted in PreviousReference but this is not recommended.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.|The rejection or acceptance of a SubscriptionBulkOrderCancellationRequest is made using an OrderCancellationStatusReport message.")]
public partial record SubscriptionBulkOrderCancellationRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptBlkOrdrCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionBulkOrderCancellationRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionBulkOrderCancellationRequestV04Document ToDocument()
    {
        return new SubscriptionBulkOrderCancellationRequestV04Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The SubscriptionBulkOrderCancellationRequest message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SubscriptionBulkOrder.
/// Usage
/// The SubscriptionBulkOrderCancellationRequest message is used to request the cancellation of one or more individual orders.
/// There is no amendment, but a cancellation and re-instruct policy.
/// To request the cancellation of one or more individual orders, the order reference of each individual order listed in the original SubscriptionBulkOrder message is specified in the order reference element. The message identification of the SubscriptionBulkOrder message which contains the individual orders to be cancelled may also be quoted in PreviousReference but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a SubscriptionBulkOrderCancellationRequest is made using an OrderCancellationStatusReport message.
/// This is the outer document that contains <seealso cref="SubscriptionBulkOrderCancellationRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionBulkOrderCancellationRequestV04Document : IOuterDocument<SubscriptionBulkOrderCancellationRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionBulkOrderCancellationRequestV04"/> is required.
    /// </summary>
    public required SubscriptionBulkOrderCancellationRequestV04 Message { get; init; }
}
