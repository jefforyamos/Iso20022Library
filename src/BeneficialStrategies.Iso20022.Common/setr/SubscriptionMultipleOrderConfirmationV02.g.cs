﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionMultipleOrderConfirmationV02.  ISO2002 ID# _1Ask6NE7Ed-BzquC8wXy7w_-475938277.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The SubscriptionMultipleOrderConfirmation message is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instruction party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to confirm the details of the execution of a SubscriptionMultipleOrder message.
/// Usage
/// The SubscriptionMultipleOrderConfirmation message is sent, after the price has been determined, to confirm the execution of the individual orders.
/// A SubscriptionMultipleOrder may be responded to by more than one SubscriptionMultipleOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.
/// When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation must be based on the references.
/// A SubscriptionMultipleOrder must in all cases be responded to by a SubscriptionMultipleOrderConfirmation message/s and in no circumstances by a SubscriptionBulkOrderConfirmation message/s.
/// If the executing party needs to confirm a SubscriptionBulkOrder message, then a SubscriptionBulkOrderConfirmation message must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SubscriptionMultipleOrderConfirmation message is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instruction party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to confirm the details of the execution of a SubscriptionMultipleOrder message.|Usage|The SubscriptionMultipleOrderConfirmation message is sent, after the price has been determined, to confirm the execution of the individual orders.|A SubscriptionMultipleOrder may be responded to by more than one SubscriptionMultipleOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.|When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation must be based on the references.|A SubscriptionMultipleOrder must in all cases be responded to by a SubscriptionMultipleOrderConfirmation message/s and in no circumstances by a SubscriptionBulkOrderConfirmation message/s.|If the executing party needs to confirm a SubscriptionBulkOrder message, then a SubscriptionBulkOrderConfirmation message must be used.")]
public partial record SubscriptionMultipleOrderConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.012.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_1Ask6dE7Ed-BzquC8wXy7w_2083815403")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public SomeMasterReferenceRecord? MasterReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_1A2V4NE7Ed-BzquC8wXy7w_2095819780")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_1A2V4dE7Ed-BzquC8wXy7w_2093971857")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_1A2V4tE7Ed-BzquC8wXy7w_2098590018")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    [Required]
    public required SomeRelatedReferenceRecord RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the execution of investment fund order.
    /// </summary>
    [IsoId("_1A2V49E7Ed-BzquC8wXy7w_955522079")]
    [Description(@"General information related to the execution of investment fund order.")]
    [DataMember(Name="MltplExctnDtls")]
    [XmlElement(ElementName="MltplExctnDtls")]
    [Required]
    public required SomeMultipleExecutionDetailsRecord MultipleExecutionDetails { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to an intermediary.
    /// </summary>
    [IsoId("_1A2V5NE7Ed-BzquC8wXy7w_536472801")]
    [Description(@"Confirmation of the information related to an intermediary.")]
    [DataMember(Name="IntrmyDtls")]
    [XmlElement(ElementName="IntrmyDtls")]
    public required IReadonlyCollection<SomeIntermediaryDetailsRecord> IntermediaryDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_1A2V5dE7Ed-BzquC8wXy7w_1679115496")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public SomeCopyDetailsRecord? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1A2V5tE7Ed-BzquC8wXy7w_678927183")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionMultipleOrderConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionMultipleOrderConfirmationV02Document ToDocument()
    {
        return new SubscriptionMultipleOrderConfirmationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionMultipleOrderConfirmationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionMultipleOrderConfirmationV02Document : IOuterDocument<SubscriptionMultipleOrderConfirmationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.012.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionMultipleOrderConfirmationV02"/> is required.
    /// </summary>
    public required SubscriptionMultipleOrderConfirmationV02 Message { get; init; }
}