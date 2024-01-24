﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReceiptAcknowledgementV01.  ISO2002 ID# _4MJ7oZb3Eee4htziCyV8eA.
//
namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// The ReceiptAcknowledgement message is sent by the transaction administrator to a member of the system and vice versa. It is sent to acknowledge the receipt of one or multiple messages sent previously. The Acknowledgement message is 1) an application receipt acknowledgement and 2) conveys information about the processing of the original message(s). In case of 2) the ReceiptAcknowledgement can be used as a Generic error message, which provides information about the status (e.g. rejection, acceptance) of an instruction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ReceiptAcknowledgement message is sent by the transaction administrator to a member of the system and vice versa. It is sent to acknowledge the receipt of one or multiple messages sent previously. The Acknowledgement message is 1) an application receipt acknowledgement and 2) conveys information about the processing of the original message(s). In case of 2) the ReceiptAcknowledgement can be used as a Generic error message, which provides information about the status (e.g. rejection, acceptance) of an instruction.")]
public partial record ReceiptAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RctAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReceiptAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReceiptAcknowledgementV01Document ToDocument()
    {
        return new ReceiptAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// The ReceiptAcknowledgement message is sent by the transaction administrator to a member of the system and vice versa. It is sent to acknowledge the receipt of one or multiple messages sent previously. The Acknowledgement message is 1) an application receipt acknowledgement and 2) conveys information about the processing of the original message(s). In case of 2) the ReceiptAcknowledgement can be used as a Generic error message, which provides information about the status (e.g. rejection, acceptance) of an instruction.
/// This is the outer document that contains <seealso cref="ReceiptAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReceiptAcknowledgementV01Document : IOuterDocument<ReceiptAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReceiptAcknowledgementV01"/> is required.
    /// </summary>
    public required ReceiptAcknowledgementV01 Message { get; init; }
}
