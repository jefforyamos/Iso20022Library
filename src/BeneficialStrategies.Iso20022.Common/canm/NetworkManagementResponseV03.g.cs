﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NetworkManagementResponseV03.  ISO2002 ID# _zF93AYv8EeumSPwlS1PkxQ.
//
namespace BeneficialStrategies.Iso20022.canm;

/// <summary>
/// The NetworkManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a NetworkManagementlInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The NetworkManagementResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a NetworkManagementlInitiation message.||")]
public partial record NetworkManagementResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtwkMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_zF93A4v8EeumSPwlS1PkxQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header63 Header { get; init; }
    
    /// <summary>
    /// Information related to the response to a network management initiation message.
    /// </summary>
    [IsoId("_zF93BYv8EeumSPwlS1PkxQ")]
    [Description(@"Information related to the response to a network management initiation message.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required NetworkManagementResponse2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_zF93B4v8EeumSPwlS1PkxQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NetworkManagementResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NetworkManagementResponseV03Document ToDocument()
    {
        return new NetworkManagementResponseV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NetworkManagementResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NetworkManagementResponseV03Document : IOuterDocument<NetworkManagementResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.002.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NetworkManagementResponseV03"/> is required.
    /// </summary>
    public required NetworkManagementResponseV03 Message { get; init; }
}
