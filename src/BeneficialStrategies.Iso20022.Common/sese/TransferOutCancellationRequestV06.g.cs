﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferOutCancellationRequestV06.  ISO2002 ID# _s0NPsT57EeSIqOPJHpnleA.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferOutInstruction.
/// Usage
/// The TransferOutCancellationRequest message is used to request cancellation of a previously sent TransferOutInstruction. There are two ways to specify the transfer cancellation request. Either:
/// - the transfer reference of the original transfer is quoted, or,
/// - all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.
/// The message identification of the TransferOutInstruction message in which the original transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferOutInstruction message by quoting its message identification in PreviousReference.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferOutInstruction.|Usage|The TransferOutCancellationRequest message is used to request cancellation of a previously sent TransferOutInstruction. There are two ways to specify the transfer cancellation request. Either:|- the transfer reference of the original transfer is quoted, or,|- all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.|The message identification of the TransferOutInstruction message in which the original transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferOutInstruction message by quoting its message identification in PreviousReference.")]
public partial record TransferOutCancellationRequestV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_s0NPsz57EeSIqOPJHpnleA")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.
    /// </summary>
    [IsoId("_s0NPtT57EeSIqOPJHpnleA")]
    [Description(@"Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    public SomeReferencesRecord? References { get; init; }
    
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [IsoId("_s0NPtz57EeSIqOPJHpnleA")]
    [Description(@"Choice between cancellation by reference or by transfer details.")]
    [DataMember(Name="Cxl")]
    [XmlElement(ElementName="Cxl")]
    [Required]
    public required SomeCancellationRecord Cancellation { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_s0NPuT57EeSIqOPJHpnleA")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public SomeMarketPracticeVersionRecord? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_s0NPuz57EeSIqOPJHpnleA")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public SomeCopyDetailsRecord? CopyDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferOutCancellationRequestV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferOutCancellationRequestV06Document ToDocument()
    {
        return new TransferOutCancellationRequestV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferOutCancellationRequestV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferOutCancellationRequestV06Document : IOuterDocument<TransferOutCancellationRequestV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.002.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferOutCancellationRequestV06"/> is required.
    /// </summary>
    public required TransferOutCancellationRequestV06 Message { get; init; }
}
