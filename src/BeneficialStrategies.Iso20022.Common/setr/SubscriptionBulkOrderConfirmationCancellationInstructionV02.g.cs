﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionBulkOrderConfirmationCancellationInstructionV02.  ISO2002 ID# _Aab7hzbLEead9bDRE_1DAQ.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The SubscriptionBulkOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SubscriptionBulkOrderConfirmation.
/// Usage
/// To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SubscriptionBulkOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SubscriptionBulkOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the subscription bulk order confirmation cancellation is to be followed by an amendment An amendment of a subscription bulk order confirmation is carried out by sending a SubscriptionBulkOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SubscriptionBulkOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SubscriptionBulkOrderConfirmation.|Usage|To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SubscriptionBulkOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SubscriptionBulkOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the subscription bulk order confirmation cancellation is to be followed by an amendment An amendment of a subscription bulk order confirmation is carried out by sending a SubscriptionBulkOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’.")]
public partial record SubscriptionBulkOrderConfirmationCancellationInstructionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptBlkOrdrConfCxlInstr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab7jTbLEead9bDRE_1DAQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab7jzbLEead9bDRE_1DAQ")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab7kTbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab7kzbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_UNkftFAZEea5nPE5ezGuuw")]
    [Description(@"Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.")]
    [DataMember(Name="AmdmntInd")]
    [XmlElement(ElementName="AmdmntInd")]
    [Required]
    public required SomeAmendmentIndicatorRecord AmendmentIndicator { get; init; }
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_UNkfs1AZEea5nPE5ezGuuw")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public SomeMasterReferenceRecord? MasterReference { get; init; }
    
    /// <summary>
    /// Identification of the individual order confirmation to be cancelled.
    /// </summary>
    [IsoId("_UNkftVAZEea5nPE5ezGuuw")]
    [Description(@"Identification of the individual order confirmation to be cancelled.")]
    [DataMember(Name="OrdrRefs")]
    [XmlElement(ElementName="OrdrRefs")]
    [Required]
    public required SomeOrderReferencesRecord OrderReferences { get; init; }
    
    /// <summary>
    /// Message is a copy.
    /// </summary>
    [IsoId("_Aab7mTbLEead9bDRE_1DAQ")]
    [Description(@"Message is a copy.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public SomeCopyDetailsRecord? CopyDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionBulkOrderConfirmationCancellationInstructionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionBulkOrderConfirmationCancellationInstructionV02Document ToDocument()
    {
        return new SubscriptionBulkOrderConfirmationCancellationInstructionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionBulkOrderConfirmationCancellationInstructionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionBulkOrderConfirmationCancellationInstructionV02Document : IOuterDocument<SubscriptionBulkOrderConfirmationCancellationInstructionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.049.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionBulkOrderConfirmationCancellationInstructionV02"/> is required.
    /// </summary>
    public required SubscriptionBulkOrderConfirmationCancellationInstructionV02 Message { get; init; }
}
