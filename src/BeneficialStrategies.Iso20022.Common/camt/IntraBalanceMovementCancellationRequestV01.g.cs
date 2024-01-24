﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementCancellationRequestV01.  ISO2002 ID# _DLtKkTncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// The IntraBalanceMovementCancellationRequest message is sent from an account owner/requestor to a settlement infrastructure to request the cancellation of a previously sent IntraBalanceMovementInstruction message.
/// Usage: 
/// The message may be used to:
/// - re-send a message previously sent (the sub-function of the message is "Duplicate")
/// - provide a third party with a copy of a message for information (the sub-function of the message is "Copy")
/// - re-send to a third party a copy of a message for information (the sub-function of the message is "CopyDuplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The IntraBalanceMovementCancellationRequest message is sent from an account owner/requestor to a settlement infrastructure to request the cancellation of a previously sent IntraBalanceMovementInstruction message.||Usage: |The message may be used to:|- re-send a message previously sent (the sub-function of the message is ""Duplicate"")|- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"")|- re-send to a third party a copy of a message for information (the sub-function of the message is ""CopyDuplicate"").")]
public partial record IntraBalanceMovementCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementCancellationRequestV01Document ToDocument()
    {
        return new IntraBalanceMovementCancellationRequestV01Document { Message = this };
    }
}

/// <summary>
/// The IntraBalanceMovementCancellationRequest message is sent from an account owner/requestor to a settlement infrastructure to request the cancellation of a previously sent IntraBalanceMovementInstruction message.
/// Usage: 
/// The message may be used to:
/// - re-send a message previously sent (the sub-function of the message is "Duplicate")
/// - provide a third party with a copy of a message for information (the sub-function of the message is "Copy")
/// - re-send to a third party a copy of a message for information (the sub-function of the message is "CopyDuplicate").
/// This is the outer document that contains <seealso cref="IntraBalanceMovementCancellationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementCancellationRequestV01Document : IOuterDocument<IntraBalanceMovementCancellationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.074.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementCancellationRequestV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementCancellationRequestV01 Message { get; init; }
}
