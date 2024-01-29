﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV11.  ISO2002 ID# _mjCuwVEJEeyApZmLzm74zA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.")]
public partial record AcceptorConfigurationUpdateV11 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_mjCuxVEJEeyApZmLzm74zA")]
    [Description(@"Set of characteristics related to the transfer of the acceptor parameters.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_mjCux1EJEeyApZmLzm74zA")]
    [Description(@"Acceptor configuration to be downloaded from the terminal management system.")]
    [DataMember(Name="AccptrCfgtn")]
    [XmlElement(ElementName="AccptrCfgtn")]
    [Required]
    public required SomeAcceptorConfigurationRecord AcceptorConfiguration { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_mjCuyVEJEeyApZmLzm74zA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorConfigurationUpdateV11Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV11Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV11Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorConfigurationUpdateV11"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorConfigurationUpdateV11Document : IOuterDocument<AcceptorConfigurationUpdateV11>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.11";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorConfigurationUpdateV11"/> is required.
    /// </summary>
    public required AcceptorConfigurationUpdateV11 Message { get; init; }
}