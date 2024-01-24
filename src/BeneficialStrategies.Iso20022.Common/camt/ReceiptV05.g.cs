﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReceiptV05.  ISO2002 ID# _jwlb8RbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The Receipt message is sent by the transaction administrator to a member of the system. It is sent to acknowledge the receipt of one or multiple messages sent previously.
/// The Receipt message is an application receipt acknowledgement and conveys information about the processing of the original message(s).
/// Usage
/// The Receipt message is used when the exchange of messages takes place in an asynchronous manner.
/// This may happen, for instance, when an action is requested from the transaction administrator (a deletion, modification or cancellation). The transaction administrator will first acknowledge the request (with a Receipt message) and then execute it.
/// The message can contain information based on the following elements: reference of the message(s) it acknowledges, the status code (optional) and further explanation:
/// - reference of the message it acknowledges
/// - potentially, a status code and an explanation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Receipt message is sent by the transaction administrator to a member of the system. It is sent to acknowledge the receipt of one or multiple messages sent previously.|The Receipt message is an application receipt acknowledgement and conveys information about the processing of the original message(s).|Usage|The Receipt message is used when the exchange of messages takes place in an asynchronous manner.|This may happen, for instance, when an action is requested from the transaction administrator (a deletion, modification or cancellation). The transaction administrator will first acknowledge the request (with a Receipt message) and then execute it.|The message can contain information based on the following elements: reference of the message(s) it acknowledges, the status code (optional) and further explanation:|- reference of the message it acknowledges|- potentially, a status code and an explanation.")]
public partial record ReceiptV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "Rct";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlb8xbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Details of the receipt.
    /// </summary>
    [IsoId("_jwlb9RbvEeiyVv5j1vf1VQ")]
    [Description(@"Details of the receipt.")]
    [DataMember(Name="RctDtls")]
    [XmlElement(ElementName="RctDtls")]
    [Required]
    public required SomeReceiptDetailsRecord ReceiptDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb9xbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReceiptV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReceiptV05Document ToDocument()
    {
        return new ReceiptV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReceiptV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReceiptV05Document : IOuterDocument<ReceiptV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.025.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReceiptV05"/> is required.
    /// </summary>
    public required ReceiptV05 Message { get; init; }
}
