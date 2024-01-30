﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionOrderConfirmationCancellationInstructionV01.  ISO2002 ID# _3hoQmNE7Ed-BzquC8wXy7w_2042447146.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// An executing party, for example, a transfer agent, sends the SubscriptionOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to cancel a previously sent SubscriptionOrderConfirmation.
/// Usage
/// The SubscriptionOrderConfirmationCancellationInstruction message is used to cancel one or more previously sent subscription order confirmations. The amendment indicator element is used to specify whether the subscription order confirmation cancellation is to be followed by a SubscriptionOrderConfirmationAmendment.
/// The SubscriptionOrderConfirmationCancellationInstruction message is used to either:
/// - cancel an entire SubscriptionOrderConfirmation message, that is, all the individual order confirmations that it contained, or,
/// - request the cancellation of one or more individual confirmations.
/// There are two ways to use the message.
/// (1) When the SubscriptionOrderConfirmationCancellationInstruction message is used to cancel an entire message, this can be done by either:
/// - quoting the business references, for example, OrderReference, Deal Reference, of all the individual order confirmations listed in the SubscriptionOrderConfirmation message, or,
/// - quoting the details of all the individual order confirmations (this includes the OrderReference and DealReference) listed in SubscriptionOrderConfirmation message but this is not recommended.
/// The message identification of the SubscriptionOrderConfirmation message may also be quoted in PreviousReference.
/// It is also possible to instruct the cancellation of an entire confirmation message by quoting its message identification in PreviousReference.
/// (2) When the SubscriptionOrderConfirmationCancellationInstruction message is used to cancel one or more individual order confirmations, this can be done by either:
/// - quoting the "business" references, for example, OrderReference, Deal Reference, of each individual order confirmation listed in the SubscriptionOrderConfirmation message, or,
/// - quoting the details of each individual order execution (this includes the OrderReference and DealReference) listed in SubscriptionOrderConfirmation message but this is not recommended.
/// The message identification of the SubscriptionOrderConfirmation message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.
/// The rejection or acceptance of a SubscriptionOrderConfirmationCancellationInstruction is made using an OrderConfirmationStatusReport message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the SubscriptionOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to cancel a previously sent SubscriptionOrderConfirmation.|Usage|The SubscriptionOrderConfirmationCancellationInstruction message is used to cancel one or more previously sent subscription order confirmations. The amendment indicator element is used to specify whether the subscription order confirmation cancellation is to be followed by a SubscriptionOrderConfirmationAmendment.|The SubscriptionOrderConfirmationCancellationInstruction message is used to either:|- cancel an entire SubscriptionOrderConfirmation message, that is, all the individual order confirmations that it contained, or,|- request the cancellation of one or more individual confirmations.|There are two ways to use the message.|(1) When the SubscriptionOrderConfirmationCancellationInstruction message is used to cancel an entire message, this can be done by either:|- quoting the business references, for example, OrderReference, Deal Reference, of all the individual order confirmations listed in the SubscriptionOrderConfirmation message, or,|- quoting the details of all the individual order confirmations (this includes the OrderReference and DealReference) listed in SubscriptionOrderConfirmation message but this is not recommended.|The message identification of the SubscriptionOrderConfirmation message may also be quoted in PreviousReference.|It is also possible to instruct the cancellation of an entire confirmation message by quoting its message identification in PreviousReference.|(2) When the SubscriptionOrderConfirmationCancellationInstruction message is used to cancel one or more individual order confirmations, this can be done by either:|- quoting the ""business"" references, for example, OrderReference, Deal Reference, of each individual order confirmation listed in the SubscriptionOrderConfirmation message, or,|- quoting the details of each individual order execution (this includes the OrderReference and DealReference) listed in SubscriptionOrderConfirmation message but this is not recommended.|The message identification of the SubscriptionOrderConfirmation message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.|The rejection or acceptance of a SubscriptionOrderConfirmationCancellationInstruction is made using an OrderConfirmationStatusReport message.")]
public partial record SubscriptionOrderConfirmationCancellationInstructionV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptOrdrConfCxlInstrV01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_3hoQmdE7Ed-BzquC8wXy7w_-909279046")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_3hoQmtE7Ed-BzquC8wXy7w_-2141787615")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_3hoQm9E7Ed-BzquC8wXy7w_-2141787904")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_3hyBkNE7Ed-BzquC8wXy7w_1948286137")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// References of the orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_3hyBkdE7Ed-BzquC8wXy7w_-2141787537")]
    [Description(@"References of the orders confirmations to be cancelled.")]
    [DataMember(Name="CxlByRef")]
    [XmlElement(ElementName="CxlByRef")]
    public InvestmentFundOrderExecution1? CancellationByReference { get; init; }
    
    /// <summary>
    /// Common information related to all the orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_3hyBktE7Ed-BzquC8wXy7w_-2141787555")]
    [Description(@"Common information related to all the orders confirmations to be cancelled.")]
    [DataMember(Name="CxlByOrdrConfDtls")]
    [XmlElement(ElementName="CxlByOrdrConfDtls")]
    public SubscriptionOrderConfirmation1? CancellationByOrderConfirmationDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_3hyBk9E7Ed-BzquC8wXy7w_-909281941")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionOrderConfirmationCancellationInstructionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionOrderConfirmationCancellationInstructionV01Document ToDocument()
    {
        return new SubscriptionOrderConfirmationCancellationInstructionV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionOrderConfirmationCancellationInstructionV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionOrderConfirmationCancellationInstructionV01Document : IOuterDocument<SubscriptionOrderConfirmationCancellationInstructionV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.047.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionOrderConfirmationCancellationInstructionV01"/> is required.
    /// </summary>
    public required SubscriptionOrderConfirmationCancellationInstructionV01 Message { get; init; }
}
