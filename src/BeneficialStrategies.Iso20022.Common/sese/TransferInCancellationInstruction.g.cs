﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInCancellationInstruction.  ISO2002 ID# _IJ9muNE6Ed-BzquC8wXy7w_-1440956956.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// TheTransferInCancellationInstruction message is sent by an instructing party, or an instructing party's designated agent, to the executing party.
/// This message is used to request the cancellation of a TransferInInstruction that was previously sent by the instructing party.
/// Usage
/// TheTransferInCancellationInstruction message is sent by an instructing party to request cancellation of a previously sent TransferInInstruction.
/// This message must contain the reference of the message to be cancelled. The message may also contain all the details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|TheTransferInCancellationInstruction message is sent by an instructing party, or an instructing party's designated agent, to the executing party.|This message is used to request the cancellation of a TransferInInstruction that was previously sent by the instructing party.|Usage|TheTransferInCancellationInstruction message is sent by an instructing party to request cancellation of a previously sent TransferInInstruction.|This message must contain the reference of the message to be cancelled. The message may also contain all the details of the message to be cancelled, but this is not recommended.")]
public partial record TransferInCancellationInstruction : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.006.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_IJ9mudE6Ed-BzquC8wXy7w_-793090656")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    [Required]
    public required SomePreviousReferenceRecord PreviousReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_IJ9mutE6Ed-BzquC8wXy7w_288100882")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_IJ9mu9E6Ed-BzquC8wXy7w_-198593769")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// The transfer in request message to cancel.
    /// </summary>
    [IsoId("_IKGwoNE6Ed-BzquC8wXy7w_97276648")]
    [Description(@"The transfer in request message to cancel.")]
    [DataMember(Name="TrfInToBeCanc")]
    [XmlElement(ElementName="TrfInToBeCanc")]
    public SomeTransferInToBeCancelledRecord? TransferInToBeCancelled { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInCancellationInstructionDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInCancellationInstructionDocument ToDocument()
    {
        return new TransferInCancellationInstructionDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInCancellationInstruction"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferInCancellationInstructionDocument : IOuterDocument<TransferInCancellationInstruction>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInCancellationInstruction"/> is required.
    /// </summary>
    public required TransferInCancellationInstruction Message { get; init; }
}