﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionBulkOrderConfirmationV02.  ISO2002 ID# _pGD-5dE7Ed-BzquC8wXy7w_314405258.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The RedemptionBulkOrderConfirmation message is sent by an executing party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to confirm the details of the execution of a RedemptionBulkOrder message.
/// Usage
/// The RedemptionBulkOrderConfirmation message is sent, after the price has been determined, to confirm the execution of all individual orders.
/// There is usually one bulk confirmation message for one bulk order message.
/// A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionMultipleOrderConfirmation.
/// If the executing party needs to confirm a RedemptionMultipleOrder message, then the RedemptionMultipleOrderConfirmation message must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RedemptionBulkOrderConfirmation message is sent by an executing party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to confirm the details of the execution of a RedemptionBulkOrder message.|Usage|The RedemptionBulkOrderConfirmation message is sent, after the price has been determined, to confirm the execution of all individual orders.|There is usually one bulk confirmation message for one bulk order message.|A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionMultipleOrderConfirmation.|If the executing party needs to confirm a RedemptionMultipleOrder message, then the RedemptionMultipleOrderConfirmation message must be used.")]
public partial record RedemptionBulkOrderConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.003.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_pGD-5tE7Ed-BzquC8wXy7w_1787375845")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_pGD-59E7Ed-BzquC8wXy7w_1776292588")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_pGD-6NE7Ed-BzquC8wXy7w_1774443914")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_pGD-6dE7Ed-BzquC8wXy7w_1778141211")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    [Required]
    public required AdditionalReference3 RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_pGNI0NE7Ed-BzquC8wXy7w_735528322")]
    [Description(@"General information related to the execution of investment fund orders.")]
    [DataMember(Name="BlkExctnDtls")]
    [XmlElement(ElementName="BlkExctnDtls")]
    [Required]
    public required RedemptionBulkExecution2 BulkExecutionDetails { get; init; }
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_pGNI0dE7Ed-BzquC8wXy7w_-833250151")]
    [Description(@"Information related to an intermediary.")]
    [DataMember(Name="IntrmyDtls")]
    [XmlElement(ElementName="IntrmyDtls")]
    public required IReadonlyCollection<Intermediary4> IntermediaryDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_pGNI0tE7Ed-BzquC8wXy7w_-1336774752")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pGNI09E7Ed-BzquC8wXy7w_-338730008")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionBulkOrderConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionBulkOrderConfirmationV02Document ToDocument()
    {
        return new RedemptionBulkOrderConfirmationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionBulkOrderConfirmationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionBulkOrderConfirmationV02Document : IOuterDocument<RedemptionBulkOrderConfirmationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionBulkOrderConfirmationV02"/> is required.
    /// </summary>
    public required RedemptionBulkOrderConfirmationV02 Message { get; init; }
}
