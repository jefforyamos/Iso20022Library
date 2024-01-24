﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AdministrativeInitiationV01.  ISO2002 ID# _wvW8wDNEEeylu6lH-gut-A.
//
namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// The AdministrativeInitiation message usually sent by any party (processor, clearing or settlement agent) to any party to inform anything that supports the business and technical infrastructure between parties.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AdministrativeInitiation message usually sent by any party (processor, clearing or settlement agent) to any party to inform anything that supports the business and technical infrastructure between parties.")]
public partial record AdministrativeInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdmstvInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_BSBd0TNFEeylu6lH-gut-A")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the financial initiation.
    /// </summary>
    [IsoId("_Kp-EoTNFEeylu6lH-gut-A")]
    [Description(@"Information related to the financial initiation.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_EzkR8TNFEeylu6lH-gut-A")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AdministrativeInitiationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AdministrativeInitiationV01Document ToDocument()
    {
        return new AdministrativeInitiationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AdministrativeInitiationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AdministrativeInitiationV01Document : IOuterDocument<AdministrativeInitiationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AdministrativeInitiationV01"/> is required.
    /// </summary>
    public required AdministrativeInitiationV01 Message { get; init; }
}
