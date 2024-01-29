﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BatchTransferInitiationV01.  ISO2002 ID# _oX5L5VXAEeeiG_nL4vgKnQ.
//
namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// The BatchTransferInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to transfer a series of transactions or administrative information in a single exchange.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The BatchTransferInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to transfer a series of transactions or administrative information in a single exchange.")]
public partial record BatchTransferInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BtchTrfInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_oX5L6FXAEeeiG_nL4vgKnQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the batch transfer.
    /// </summary>
    [IsoId("_oX5L6VXAEeeiG_nL4vgKnQ")]
    [Description(@"Information related to the batch transfer.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_oX5L51XAEeeiG_nL4vgKnQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BatchTransferInitiationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BatchTransferInitiationV01Document ToDocument()
    {
        return new BatchTransferInitiationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BatchTransferInitiationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BatchTransferInitiationV01Document : IOuterDocument<BatchTransferInitiationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.003.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BatchTransferInitiationV01"/> is required.
    /// </summary>
    public required BatchTransferInitiationV01 Message { get; init; }
}