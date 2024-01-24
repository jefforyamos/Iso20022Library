﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BatchTransferResponseV02.  ISO2002 ID# _L1QloZMsEeuleeHpFMMhmQ.
//
namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// The BatchTransferResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchTransferInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The BatchTransferResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchTransferInitiation message.")]
public partial record BatchTransferResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchTrfRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BatchTransferResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BatchTransferResponseV02Document ToDocument()
    {
        return new BatchTransferResponseV02Document { Message = this };
    }
}

/// <summary>
/// The BatchTransferResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a BatchTransferInitiation message.
/// This is the outer document that contains <seealso cref="BatchTransferResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BatchTransferResponseV02Document : IOuterDocument<BatchTransferResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BatchTransferResponseV02"/> is required.
    /// </summary>
    public required BatchTransferResponseV02 Message { get; init; }
}
