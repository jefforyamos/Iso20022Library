﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV08.  ISO2002 ID# _yuPRkdXyEeia9rtBTv_9KA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// Update of the acceptor configuration to be downloaded by the terminal management system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Update of the acceptor configuration to be downloaded by the terminal management system.")]
public partial record AcceptorConfigurationUpdateV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_yuQfsdXyEeia9rtBTv_9KA")]
    [Description(@"Set of characteristics related to the transfer of the acceptor parameters.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_yuQfs9XyEeia9rtBTv_9KA")]
    [Description(@"Acceptor configuration to be downloaded from the terminal management system.")]
    [DataMember(Name="AccptrCfgtn")]
    [XmlElement(ElementName="AccptrCfgtn")]
    [Required]
    public required SomeAcceptorConfigurationRecord AcceptorConfiguration { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_yuQftdXyEeia9rtBTv_9KA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorConfigurationUpdateV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV08Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorConfigurationUpdateV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorConfigurationUpdateV08Document : IOuterDocument<AcceptorConfigurationUpdateV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorConfigurationUpdateV08"/> is required.
    /// </summary>
    public required AcceptorConfigurationUpdateV08 Message { get; init; }
}
