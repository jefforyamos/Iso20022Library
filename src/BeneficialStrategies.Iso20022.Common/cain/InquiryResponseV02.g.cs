﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InquiryResponseV02.  ISO2002 ID# _xBSuIYaZEeuSbct6WWD-Ng.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The InquiryResponse message is sent by an issuer or an agent to an acquirer in response to an  InquiryInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The InquiryResponse message is sent by an issuer or an agent to an acquirer in response to an  InquiryInitiation message.")]
public partial record InquiryResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NqryRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_xBSuI4aZEeuSbct6WWD-Ng")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the inquiry response.
    /// </summary>
    [IsoId("_xBSuJYaZEeuSbct6WWD-Ng")]
    [Description(@"Information related to the inquiry response.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_xBSuJ4aZEeuSbct6WWD-Ng")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InquiryResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InquiryResponseV02Document ToDocument()
    {
        return new InquiryResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InquiryResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InquiryResponseV02Document : IOuterDocument<InquiryResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.017.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InquiryResponseV02"/> is required.
    /// </summary>
    public required InquiryResponseV02 Message { get; init; }
}