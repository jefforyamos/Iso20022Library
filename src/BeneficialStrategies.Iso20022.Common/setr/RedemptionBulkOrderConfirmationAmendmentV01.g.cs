﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionBulkOrderConfirmationAmendmentV01.  ISO2002 ID# _oK5XINE7Ed-BzquC8wXy7w_-352837634.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// An executing party, for example, a transfer agent, sends the RedemptionBulkOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent RedemptionBulkOrderConfirmation message.
/// Usage
/// The RedemptionBulkOrderConfirmationAmendment message is used to amend one or more previously sent redemption bulk order confirmations.
/// Each bulk order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.
/// The message identification of the RedemptionBulkOrder message in which the orders were conveyed may also be quoted in RelatedReference. The message identification of the RedemptionBulkOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the RedemptionBulkOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent RedemptionBulkOrderConfirmation message.|Usage|The RedemptionBulkOrderConfirmationAmendment message is used to amend one or more previously sent redemption bulk order confirmations.|Each bulk order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.|The message identification of the RedemptionBulkOrder message in which the orders were conveyed may also be quoted in RelatedReference. The message identification of the RedemptionBulkOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference.")]
public partial record RedemptionBulkOrderConfirmationAmendmentV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedBlkOrdrConfAmdmntV01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_oK5XIdE7Ed-BzquC8wXy7w_-86056513")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_oK5XItE7Ed-BzquC8wXy7w_-86979123")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_oK5XI9E7Ed-BzquC8wXy7w_-86978193")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_oK5XJNE7Ed-BzquC8wXy7w_-86978625")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_oK5XJdE7Ed-BzquC8wXy7w_-86057057")]
    [Description(@"General information related to the execution of investment fund orders.")]
    [DataMember(Name="BlkExctnDtls")]
    [XmlElement(ElementName="BlkExctnDtls")]
    [Required]
    public required RedemptionBulkExecution3 BulkExecutionDetails { get; init; }
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_oK5XJtE7Ed-BzquC8wXy7w_-86977676")]
    [Description(@"Information about parties related to the transaction.")]
    [DataMember(Name="RltdPtyDtls")]
    [XmlElement(ElementName="RltdPtyDtls")]
    public required IReadonlyCollection<Intermediary9> RelatedPartyDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_oK5XJ9E7Ed-BzquC8wXy7w_-86977520")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_oK5XKNE7Ed-BzquC8wXy7w_-86057117")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionBulkOrderConfirmationAmendmentV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionBulkOrderConfirmationAmendmentV01Document ToDocument()
    {
        return new RedemptionBulkOrderConfirmationAmendmentV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionBulkOrderConfirmationAmendmentV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionBulkOrderConfirmationAmendmentV01Document : IOuterDocument<RedemptionBulkOrderConfirmationAmendmentV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.054.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionBulkOrderConfirmationAmendmentV01"/> is required.
    /// </summary>
    public required RedemptionBulkOrderConfirmationAmendmentV01 Message { get; init; }
}
