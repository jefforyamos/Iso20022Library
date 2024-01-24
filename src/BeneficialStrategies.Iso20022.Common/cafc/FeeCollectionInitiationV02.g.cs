﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FeeCollectionInitiationV02.  ISO2002 ID# _3auewYaAEeuSbct6WWD-Ng.
//
namespace BeneficialStrategies.Iso20022.cafc;

/// <summary>
/// The FeeCollectionInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) to claim or pay a miscellaneous service between financial institutions. Fee collection messages have financial impacts and affect reconciliation totals without affecting a cardholder account.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FeeCollectionInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) to claim or pay a miscellaneous service between financial institutions. Fee collection messages have financial impacts and affect reconciliation totals without affecting a cardholder account.||")]
public partial record FeeCollectionInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FeeColltnInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// ISO 8583 MTI
    /// </summary>
    [IsoId("_3avF0YaAEeuSbct6WWD-Ng")]
    [Description(@"Information related to the protocol management.|ISO 8583 MTI")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the initiation of a fee collection.
    /// </summary>
    [IsoId("_3avF04aAEeuSbct6WWD-Ng")]
    [Description(@"Information related to the initiation of a fee collection.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_3avF1YaAEeuSbct6WWD-Ng")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FeeCollectionInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FeeCollectionInitiationV02Document ToDocument()
    {
        return new FeeCollectionInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FeeCollectionInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FeeCollectionInitiationV02Document : IOuterDocument<FeeCollectionInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafc.001.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FeeCollectionInitiationV02"/> is required.
    /// </summary>
    public required FeeCollectionInitiationV02 Message { get; init; }
}
