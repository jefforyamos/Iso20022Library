﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NetworkManagementResponseV02.  ISO2002 ID# _NYnwlVWVEeeiG_nL4vgKnQ.
//
namespace BeneficialStrategies.Iso20022.canm;

/// <summary>
/// The NetworkManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a NetworkManagementlInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The NetworkManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a NetworkManagementlInitiation message.||")]
public partial record NetworkManagementResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtwkMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_NYnwllWVEeeiG_nL4vgKnQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header43 Header { get; init; }
    
    /// <summary>
    /// Information related to the response to a network management initiation message.
    /// </summary>
    [IsoId("_NYnwmVWVEeeiG_nL4vgKnQ")]
    [Description(@"Information related to the response to a network management initiation message.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required NetworkManagementResponse1 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_NYnwmFWVEeeiG_nL4vgKnQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NetworkManagementResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NetworkManagementResponseV02Document ToDocument()
    {
        return new NetworkManagementResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NetworkManagementResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NetworkManagementResponseV02Document : IOuterDocument<NetworkManagementResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NetworkManagementResponseV02"/> is required.
    /// </summary>
    public required NetworkManagementResponseV02 Message { get; init; }
}
