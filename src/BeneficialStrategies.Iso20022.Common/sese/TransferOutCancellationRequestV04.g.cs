﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferOutCancellationRequestV04.  ISO2002 ID# _EmP8-RgCEeKqWJINzXcn5g.
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
public partial record TransferOutCancellationRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferOutCancellationRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferOutCancellationRequestV04Document ToDocument()
    {
        return new TransferOutCancellationRequestV04Document { Message = this };
    }
}

/// <summary>
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferOutInstruction.
/// Usage
/// The TransferOutCancellationRequest message is used to request cancellation of a previously sent TransferOutInstruction. There are two ways to specify the transfer cancellation request. Either:
/// - the transfer reference of the original transfer is quoted, or,
/// - all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.
/// The message identification of the TransferOutInstruction message in which the original transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferOutInstruction message by quoting its message identification in PreviousReference.
/// This is the outer document that contains <seealso cref="TransferOutCancellationRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferOutCancellationRequestV04Document : IOuterDocument<TransferOutCancellationRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.002.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferOutCancellationRequestV04"/> is required.
    /// </summary>
    public required TransferOutCancellationRequestV04 Message { get; init; }
}
