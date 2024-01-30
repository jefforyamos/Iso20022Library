﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionOrderConfirmationV03.  ISO2002 ID# _utoEWNE7Ed-BzquC8wXy7w_1346008013.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of execution for a previously received RedemptionOrder message.
/// Usage
/// The RedemptionOrderConfirmation message is used to confirm the execution of one or more individual orders.
/// A RedemptionOrder message containing more than one individual order may be responded to by more than one RedemptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in RelatedReference.
/// When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation should be based on the references.
/// A RedemptionOrder must in all cases be responded to by a RedemptionOrderConfirmation message and in no circumstances by a RedemptionBulkOrderConfirmation message.
/// If the executing party needs to confirm a RedemptionBulkOrder message, then a RedemptionBulkOrderConfirmation message must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of execution for a previously received RedemptionOrder message.|Usage|The RedemptionOrderConfirmation message is used to confirm the execution of one or more individual orders.|A RedemptionOrder message containing more than one individual order may be responded to by more than one RedemptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.|Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in RelatedReference.|When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation should be based on the references.|A RedemptionOrder must in all cases be responded to by a RedemptionOrderConfirmation message and in no circumstances by a RedemptionBulkOrderConfirmation message.|If the executing party needs to confirm a RedemptionBulkOrder message, then a RedemptionBulkOrderConfirmation message must be used.")]
public partial record RedemptionOrderConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrConfV03";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_utxOQNE7Ed-BzquC8wXy7w_-1539573830")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_utxOQdE7Ed-BzquC8wXy7w_-412970353")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_utxOQtE7Ed-BzquC8wXy7w_-411121699")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_utxOQ9E7Ed-BzquC8wXy7w_-400964997")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_utxORNE7Ed-BzquC8wXy7w_1763770658")]
    [Description(@"General information related to the execution of investment fund orders.")]
    [DataMember(Name="MltplExctnDtls")]
    [XmlElement(ElementName="MltplExctnDtls")]
    [Required]
    public required RedemptionMultipleExecution3 MultipleExecutionDetails { get; init; }
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_utxORdE7Ed-BzquC8wXy7w_645385224")]
    [Description(@"Information about parties related to the transaction.")]
    [DataMember(Name="RltdPtyDtls")]
    [XmlElement(ElementName="RltdPtyDtls")]
    public required IReadonlyCollection<Intermediary9> RelatedPartyDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_utxORtE7Ed-BzquC8wXy7w_647232459")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_utxOR9E7Ed-BzquC8wXy7w_649080424")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionOrderConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionOrderConfirmationV03Document ToDocument()
    {
        return new RedemptionOrderConfirmationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionOrderConfirmationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionOrderConfirmationV03Document : IOuterDocument<RedemptionOrderConfirmationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.006.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionOrderConfirmationV03"/> is required.
    /// </summary>
    public required RedemptionOrderConfirmationV03 Message { get; init; }
}
