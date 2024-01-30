﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for HostToATMAcknowledgementV01.  ISO2002 ID# _uoX0IItrEeSDLd7nI4Quzw.
//
namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// The HostToATMAcknowledgement message is sent by an ATM to a host to acknowledge the receipt of a HostToATMRequest message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The HostToATMAcknowledgement message is sent by an ATM to a host to acknowledge the receipt of a HostToATMRequest message.")]
public partial record HostToATMAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "HstToATMAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_0sB_sItrEeSDLd7nI4Quzw")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header20 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_7SogQItrEeSDLd7nI4Quzw")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdHstToATMAck")]
    [XmlElement(ElementName="PrtctdHstToATMAck")]
    public ContentInformationType10? ProtectedHostToATMAcknowledgement { get; init; }
    
    /// <summary>
    /// Information related to the acknowledgement from an ATM to contact the ATM manager.
    /// </summary>
    [IsoId("_FlTp8ItsEeSDLd7nI4Quzw")]
    [Description(@"Information related to the acknowledgement from an ATM to contact the ATM manager.")]
    [DataMember(Name="HstToATMAck")]
    [XmlElement(ElementName="HstToATMAck")]
    public HostToATMAcknowledgement1? HostToATMAcknowledgement { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_JNBXgItsEeSDLd7nI4Quzw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="HostToATMAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public HostToATMAcknowledgementV01Document ToDocument()
    {
        return new HostToATMAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="HostToATMAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record HostToATMAcknowledgementV01Document : IOuterDocument<HostToATMAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="HostToATMAcknowledgementV01"/> is required.
    /// </summary>
    public required HostToATMAcknowledgementV01 Message { get; init; }
}
