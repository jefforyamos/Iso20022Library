﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionOrderConfirmationAmendmentV01.  ISO2002 ID# _3HjjstE7Ed-BzquC8wXy7w_-2084438867.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// An executing party, for example, a transfer agent, sends the SubscriptionOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SubscriptionOrderConfirmation.
/// Usage
/// The SubscriptionOrderConfirmationAmendment message is used to amend one or more previously sent subscription order confirmations.
/// Each individual order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.
/// The message identification of the SubscriptionOrder message in which the individual orders were conveyed may also be quoted in RelatedReference. The message identification of the SubscriptionOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the SubscriptionOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SubscriptionOrderConfirmation.|Usage|The SubscriptionOrderConfirmationAmendment message is used to amend one or more previously sent subscription order confirmations.|Each individual order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.|The message identification of the SubscriptionOrder message in which the individual orders were conveyed may also be quoted in RelatedReference. The message identification of the SubscriptionOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference.")]
public partial record SubscriptionOrderConfirmationAmendmentV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptOrdrConfAmdmntV01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_3Hjjs9E7Ed-BzquC8wXy7w_863350222")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_3HjjtNE7Ed-BzquC8wXy7w_858732782")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_3HjjtdE7Ed-BzquC8wXy7w_858735058")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_3HjjttE7Ed-BzquC8wXy7w_859657174")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the execution of investment fund order.
    /// </summary>
    [IsoId("_3Hjjt9E7Ed-BzquC8wXy7w_862427227")]
    [Description(@"General information related to the execution of investment fund order.")]
    [DataMember(Name="MltplExctnDtls")]
    [XmlElement(ElementName="MltplExctnDtls")]
    [Required]
    public required SomeMultipleExecutionDetailsRecord MultipleExecutionDetails { get; init; }
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_3HjjuNE7Ed-BzquC8wXy7w_860579233")]
    [Description(@"Information about parties related to the transaction.")]
    [DataMember(Name="RltdPtyDtls")]
    [XmlElement(ElementName="RltdPtyDtls")]
    public required IReadonlyCollection<SomeRelatedPartyDetailsRecord> RelatedPartyDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_3HtUsNE7Ed-BzquC8wXy7w_861502126")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public SomeCopyDetailsRecord? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_3HtUsdE7Ed-BzquC8wXy7w_861505547")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionOrderConfirmationAmendmentV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionOrderConfirmationAmendmentV01Document ToDocument()
    {
        return new SubscriptionOrderConfirmationAmendmentV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionOrderConfirmationAmendmentV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionOrderConfirmationAmendmentV01Document : IOuterDocument<SubscriptionOrderConfirmationAmendmentV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionOrderConfirmationAmendmentV01"/> is required.
    /// </summary>
    public required SubscriptionOrderConfirmationAmendmentV01 Message { get; init; }
}
