﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RetrievalResponseV02.  ISO2002 ID# _w1uw0YHXEeu7P-fjMhpKOg.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The RetrievalResponse message is sent by an acquirer to an issuer or agent in response to an Retrievalnitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RetrievalResponse message is sent by an acquirer to an issuer or agent in response to an Retrievalnitiation message.")]
public partial record RetrievalResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrvlRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_w1vX4YHXEeu7P-fjMhpKOg")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the response to the request of a retrieval of information.
    /// </summary>
    [IsoId("_w1vX44HXEeu7P-fjMhpKOg")]
    [Description(@"Information related to the response to the request of a retrieval of information.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_w1vX5YHXEeu7P-fjMhpKOg")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RetrievalResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RetrievalResponseV02Document ToDocument()
    {
        return new RetrievalResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RetrievalResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RetrievalResponseV02Document : IOuterDocument<RetrievalResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.022.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RetrievalResponseV02"/> is required.
    /// </summary>
    public required RetrievalResponseV02 Message { get; init; }
}