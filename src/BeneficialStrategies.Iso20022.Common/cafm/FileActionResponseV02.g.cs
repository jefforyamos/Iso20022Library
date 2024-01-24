﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FileActionResponseV02.  ISO2002 ID# _1ejJcYKwEeu4svNQ5N-l6w.
//
namespace BeneficialStrategies.Iso20022.cafm;

/// <summary>
/// A FileActionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FileActionInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"A FileActionResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a FileActionInitiation message.")]
public partial record FileActionResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FileActnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_1ejJc4KwEeu4svNQ5N-l6w")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the response to of a file action.
    /// </summary>
    [IsoId("_1ejJdYKwEeu4svNQ5N-l6w")]
    [Description(@"Information related to the response to of a file action.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_1ejJd4KwEeu4svNQ5N-l6w")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FileActionResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FileActionResponseV02Document ToDocument()
    {
        return new FileActionResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FileActionResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FileActionResponseV02Document : IOuterDocument<FileActionResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafm.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FileActionResponseV02"/> is required.
    /// </summary>
    public required FileActionResponseV02 Message { get; init; }
}
