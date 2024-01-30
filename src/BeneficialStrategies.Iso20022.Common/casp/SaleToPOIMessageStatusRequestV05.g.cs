﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIMessageStatusRequestV05.  ISO2002 ID# _giUykXPJEe2pK6udhxEaHA.
//
namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// The SaleToPOIMessageStatusRequest message is sent by a sale system when the sale system wants to know the status of previous message that has not be answered.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SaleToPOIMessageStatusRequest message is sent by a sale system when the sale system wants to know the status of previous message that has not be answered.")]
public partial record SaleToPOIMessageStatusRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIMsgStsReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_giUyk3PJEe2pK6udhxEaHA")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header41 Header { get; init; }
    
    /// <summary>
    /// Information related to a status request.
    /// </summary>
    [IsoId("_giUylXPJEe2pK6udhxEaHA")]
    [Description(@"Information related to a status request.")]
    [DataMember(Name="StsReq")]
    [XmlElement(ElementName="StsReq")]
    [Required]
    public required MessageStatusRequest6 StatusRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_giUyl3PJEe2pK6udhxEaHA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType33? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOIMessageStatusRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIMessageStatusRequestV05Document ToDocument()
    {
        return new SaleToPOIMessageStatusRequestV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOIMessageStatusRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOIMessageStatusRequestV05Document : IOuterDocument<SaleToPOIMessageStatusRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.014.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOIMessageStatusRequestV05"/> is required.
    /// </summary>
    public required SaleToPOIMessageStatusRequestV05 Message { get; init; }
}
