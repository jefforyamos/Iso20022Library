﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionBulkOrderConfirmationV03.  ISO2002 ID# _zVj4wNE7Ed-BzquC8wXy7w_616882747.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// An executing party, for example, a transfer agent sends the SubscriptionBulkOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of the execution of a SubscriptionBulkOrder instruction.
/// Usage
/// The SubscriptionBulkOrderConfirmation message is used to confirm the execution of all individual orders.
/// There is usually one bulk confirmation message for one bulk order message.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the SubscriptionBulkOrder message in which the individual order was conveyed may also be quoted in RelatedReference.
/// A SubscriptionBulkOrder must in all cases be responded to by a SubscriptionBulkOrderConfirmation and in no circumstances by a SubscriptionOrderConfirmation.
/// If the executing party needs to confirm a SubscriptionOrder instruction, then the SubscriptionOrderConfirmation must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent sends the SubscriptionBulkOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of the execution of a SubscriptionBulkOrder instruction.|Usage|The SubscriptionBulkOrderConfirmation message is used to confirm the execution of all individual orders.|There is usually one bulk confirmation message for one bulk order message.|Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the SubscriptionBulkOrder message in which the individual order was conveyed may also be quoted in RelatedReference.|A SubscriptionBulkOrder must in all cases be responded to by a SubscriptionBulkOrderConfirmation and in no circumstances by a SubscriptionOrderConfirmation.|If the executing party needs to confirm a SubscriptionOrder instruction, then the SubscriptionOrderConfirmation must be used.")]
public partial record SubscriptionBulkOrderConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptBlkOrdrConfV03";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_zVj4wdE7Ed-BzquC8wXy7w_-725950414")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_zVj4wtE7Ed-BzquC8wXy7w_1301211464")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_zVj4w9E7Ed-BzquC8wXy7w_1303059499")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_zVj4xNE7Ed-BzquC8wXy7w_1313217658")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the execution of investment orders.
    /// </summary>
    [IsoId("_zVj4xdE7Ed-BzquC8wXy7w_-1660193120")]
    [Description(@"General information related to the execution of investment orders.")]
    [DataMember(Name="BlkExctnDtls")]
    [XmlElement(ElementName="BlkExctnDtls")]
    [Required]
    public required SomeBulkExecutionDetailsRecord BulkExecutionDetails { get; init; }
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_zVj4xtE7Ed-BzquC8wXy7w_1750042192")]
    [Description(@"Information about parties related to the transaction.")]
    [DataMember(Name="RltdPtyDtls")]
    [XmlElement(ElementName="RltdPtyDtls")]
    public required IReadonlyCollection<SomeRelatedPartyDetailsRecord> RelatedPartyDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_zVj4x9E7Ed-BzquC8wXy7w_1758354425")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public SomeCopyDetailsRecord? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_zVtpwNE7Ed-BzquC8wXy7w_1761122916")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionBulkOrderConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionBulkOrderConfirmationV03Document ToDocument()
    {
        return new SubscriptionBulkOrderConfirmationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionBulkOrderConfirmationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionBulkOrderConfirmationV03Document : IOuterDocument<SubscriptionBulkOrderConfirmationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.009.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionBulkOrderConfirmationV03"/> is required.
    /// </summary>
    public required SubscriptionBulkOrderConfirmationV03 Message { get; init; }
}
