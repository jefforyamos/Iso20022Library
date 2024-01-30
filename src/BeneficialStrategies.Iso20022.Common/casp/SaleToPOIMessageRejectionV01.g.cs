﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIMessageRejectionV01.  ISO2002 ID# _4R49hN6cEeiwsev40qZGEQ.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// A Message Rejection is sent by one of the parties when it detects a technical or functional error in a previous received message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"A Message Rejection is sent by one of the parties when it detects a technical or functional error in a previous received message.")]
public partial record SaleToPOIMessageRejectionV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIMsgRjctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_4R49ht6cEeiwsev40qZGEQ")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header37 Header { get; init; }
    
    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_vgCQ4d6dEeiwsev40qZGEQ")]
    [Description(@"Information related to the reject.")]
    [DataMember(Name="Rjct")]
    [XmlElement(ElementName="Rjct")]
    [Required]
    public required AcceptorRejection2 Reject { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIMessageRejectionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIMessageRejectionV01Document ToDocument()
    {
        return new SaleToPOIMessageRejectionV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIMessageRejectionV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIMessageRejectionV01Document : IOuterDocument<SaleToPOIMessageRejectionV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIMessageRejectionV01"/> is required.
    /// </summary>
    public required SaleToPOIMessageRejectionV01 Message { get; init; }
}
