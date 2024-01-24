﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CardManagementInitiationV01.  ISO2002 ID# _XXmzJVgPEeedJb6VxsnkPg.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The CardManagementInitiation message is sent by the acquirer to an issuer or agent to fulfil a request initiated by the cardholder at the point of service for an operation on the card account.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CardManagementInitiation message is sent by the acquirer to an issuer or agent to fulfil a request initiated by the cardholder at the point of service for an operation on the card account.")]
public partial record CardManagementInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CardMgmtInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_XXmzKFgPEeedJb6VxsnkPg")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the card management initiation.
    /// </summary>
    [IsoId("_XXmzJ1gPEeedJb6VxsnkPg")]
    [Description(@"Information related to the card management initiation.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_XXmzKVgPEeedJb6VxsnkPg")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CardManagementInitiationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CardManagementInitiationV01Document ToDocument()
    {
        return new CardManagementInitiationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CardManagementInitiationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CardManagementInitiationV01Document : IOuterDocument<CardManagementInitiationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.023.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CardManagementInitiationV01"/> is required.
    /// </summary>
    public required CardManagementInitiationV01 Message { get; init; }
}
