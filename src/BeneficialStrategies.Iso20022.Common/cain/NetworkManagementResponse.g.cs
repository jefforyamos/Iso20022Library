﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NetworkManagementResponse.  ISO2002 ID# _Goob8HvFEeSKFIcWw3l4Yw.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The NetworkManagementResponse message is sent by an acquirer, an issuer or an agent to answer to an NetworkManagementInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The NetworkManagementResponse message is sent by an acquirer, an issuer or an agent to answer to an NetworkManagementInitiation message.")]
public partial record NetworkManagementResponse : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtwkMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_UehNsHvFEeSKFIcWw3l4Yw")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header17 Header { get; init; }
    
    /// <summary>
    /// Information related to the response to the network management.
    /// </summary>
    [IsoId("_gRKVUHvFEeSKFIcWw3l4Yw")]
    [Description(@"Information related to the response to the network management.")]
    [DataMember(Name="NtwkMgmtRspn")]
    [XmlElement(ElementName="NtwkMgmtRspn")]
    [Required]
    public required AcquirerNetworkManagementResponse1 NetworkManagementResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_OCK_4HvGEeSKFIcWw3l4Yw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NetworkManagementResponseDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NetworkManagementResponseDocument ToDocument()
    {
        return new NetworkManagementResponseDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NetworkManagementResponse"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NetworkManagementResponseDocument : IOuterDocument<NetworkManagementResponse>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NetworkManagementResponse"/> is required.
    /// </summary>
    public required NetworkManagementResponse Message { get; init; }
}
