﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ChargeBackInitiationV02.  ISO2002 ID# _52D7IYHSEeuwq_rv81SdXw.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The ChargeBackInitiation message is sent by an issuer or agent to an acquirer to fully or partially nullify a previous financial transaction; namely when the issuer determines that a customer dispute exists or that an error or violation of rules has been committed. It is also used to nullify a previous chargeback. Chargebacks have a financial impact and should be computed within reconciliation totals.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ChargeBackInitiation message is sent by an issuer or agent to an acquirer to fully or partially nullify a previous financial transaction; namely when the issuer determines that a customer dispute exists or that an error or violation of rules has been committed. It is also used to nullify a previous chargeback. Chargebacks have a financial impact and should be computed within reconciliation totals.")]
public partial record ChargeBackInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChrgBckInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_52D7I4HSEeuwq_rv81SdXw")]
    [Description(@"Information related to the protocol management.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header61 Header { get; init; }
    
    /// <summary>
    /// Information related to the initiation of a chargeback.
    /// ISO 8583:93/2003 bit 25.
    /// </summary>
    [IsoId("_52D7JYHSEeuwq_rv81SdXw")]
    [Description(@"Information related to the initiation of a chargeback.|ISO 8583:93/2003 bit 25.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required ChargeBackInitiation2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_52D7J4HSEeuwq_rv81SdXw")]
    [Description(@"Trailer of the message containing a MAC.|It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ChargeBackInitiationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ChargeBackInitiationV02Document ToDocument()
    {
        return new ChargeBackInitiationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ChargeBackInitiationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ChargeBackInitiationV02Document : IOuterDocument<ChargeBackInitiationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.027.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ChargeBackInitiationV02"/> is required.
    /// </summary>
    public required ChargeBackInitiationV02 Message { get; init; }
}
