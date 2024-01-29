﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FeeCollectionResponseV01.  ISO2002 ID# _WzFGdFciEeeFltjJxERUxw.
//
namespace BeneficialStrategies.Iso20022.cafc;

/// <summary>
/// The FeeCollectionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FeeCollectionInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FeeCollectionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FeeCollectionInitiation message.")]
public partial record FeeCollectionResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FeeColltnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// ISO 8583 MTI
    /// </summary>
    [IsoId("_WzFGd1ciEeeFltjJxERUxw")]
    [Description(@"Information related to the protocol management.|ISO 8583 MTI")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the response of a fee collection initiation message..
    /// </summary>
    [IsoId("_WzFGdlciEeeFltjJxERUxw")]
    [Description(@"Information related to the response of a fee collection initiation message..")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_WzFGdVciEeeFltjJxERUxw")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FeeCollectionResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FeeCollectionResponseV01Document ToDocument()
    {
        return new FeeCollectionResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FeeCollectionResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FeeCollectionResponseV01Document : IOuterDocument<FeeCollectionResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafc.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FeeCollectionResponseV01"/> is required.
    /// </summary>
    public required FeeCollectionResponseV01 Message { get; init; }
}