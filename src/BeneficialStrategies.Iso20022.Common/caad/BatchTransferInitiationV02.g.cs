﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BatchTransferInitiationV02.  ISO2002 ID# _oMldAZMrEeuleeHpFMMhmQ.
//
namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// The BatchTransferInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to transfer a series of transactions or administrative information in a single exchange.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The BatchTransferInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to transfer a series of transactions or administrative information in a single exchange.")]
public partial record BatchTransferInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchTrfInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BatchTransferInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BatchTransferInitiationV02Document ToDocument()
    {
        return new BatchTransferInitiationV02Document { Message = this };
    }
}

/// <summary>
/// The BatchTransferInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to transfer a series of transactions or administrative information in a single exchange.
/// This is the outer document that contains <seealso cref="BatchTransferInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BatchTransferInitiationV02Document : IOuterDocument<BatchTransferInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BatchTransferInitiationV02"/> is required.
    /// </summary>
    public required BatchTransferInitiationV02 Message { get; init; }
}
