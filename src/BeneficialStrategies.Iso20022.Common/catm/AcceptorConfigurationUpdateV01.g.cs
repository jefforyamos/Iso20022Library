﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV01.  ISO2002 ID# _AgFfYOQXEeCGktPI9k4Dlw_1733626146.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// Scope
/// The AcceptorConfigurationUpdate message is sent by the master terminal manager or delegated terminal manager to the acceptor system for the update of acquirer parameters, merchant parameters, vendor parameters or cryptographic keys of the acquirer.
/// Usage
/// The AcceptorConfigurationUpdate message may embed the information required by the acceptor system for the configuration of:
/// - the application parameters necessary for software applications processed by the POI system,
/// - the acquirer protocol parameters for the message content and message exchange behaviour of the acquirer protocol supported by the POI system,
/// - the host communication parameters to define the addresses of the connected acquirer hosts, and
/// - the merchant parameters needed for the retailer protocol settings of the POI system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorConfigurationUpdate message is sent by the master terminal manager or delegated terminal manager to the acceptor system for the update of acquirer parameters, merchant parameters, vendor parameters or cryptographic keys of the acquirer.|Usage|The AcceptorConfigurationUpdate message may embed the information required by the acceptor system for the configuration of:|- the application parameters necessary for software applications processed by the POI system,|- the acquirer protocol parameters for the message content and message exchange behaviour of the acquirer protocol supported by the POI system,|- the host communication parameters to define the addresses of the connected acquirer hosts, and|- the merchant parameters needed for the retailer protocol settings of the POI system.")]
public partial record AcceptorConfigurationUpdateV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_AgFfYeQXEeCGktPI9k4Dlw_-1237434314")]
    [Description(@"Set of characteristics related to the transfer of the acceptor parameters.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header4 Header { get; init; }
    
    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_AgFfYuQXEeCGktPI9k4Dlw_950623241")]
    [Description(@"Acceptor configuration to be downloaded from the terminal management system.")]
    [DataMember(Name="AccptrCfgtn")]
    [XmlElement(ElementName="AccptrCfgtn")]
    [Required]
    public required AcceptorConfiguration1 AcceptorConfiguration { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_AgFfY-QXEeCGktPI9k4Dlw_543485283")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType1 SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorConfigurationUpdateV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV01Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorConfigurationUpdateV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorConfigurationUpdateV01Document : IOuterDocument<AcceptorConfigurationUpdateV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorConfigurationUpdateV01"/> is required.
    /// </summary>
    public required AcceptorConfigurationUpdateV01 Message { get; init; }
}
