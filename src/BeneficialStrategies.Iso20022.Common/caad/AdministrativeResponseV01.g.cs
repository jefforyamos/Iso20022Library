﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AdministrativeResponseV01.  ISO2002 ID# _4xvBUDNQEeylu6lH-gut-A.
//
namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// The AdministrativeResponse message is usually sent by any party (processor, clearing or settlement agent) to any party in response to a AdministrativeInitiation Message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AdministrativeResponse message is usually sent by any party (processor, clearing or settlement agent) to any party in response to a AdministrativeInitiation Message.")]
public partial record AdministrativeResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdmstvRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_ijx78TNREeylu6lH-gut-A")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the Administrative Response.
    /// </summary>
    [IsoId("_KMg-cDZ4EeysP8L3U1Ot-g")]
    [Description(@"Information related to the Administrative Response.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_jWqxcTNREeylu6lH-gut-A")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AdministrativeResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AdministrativeResponseV01Document ToDocument()
    {
        return new AdministrativeResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AdministrativeResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AdministrativeResponseV01Document : IOuterDocument<AdministrativeResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.009.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AdministrativeResponseV01"/> is required.
    /// </summary>
    public required AdministrativeResponseV01 Message { get; init; }
}