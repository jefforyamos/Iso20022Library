﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMExceptionAdviceV01.  ISO2002 ID# _i58PwK5CEeWCgYcWSNgX5g.
//
namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// The ATMExceptionAdvice message is sent by an ATM to an acquirer or its agent to inform of that an exception occurred outside a service.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMExceptionAdvice message is sent by an ATM to an acquirer or its agent to inform of that an exception occurred outside a service.")]
public partial record ATMExceptionAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMXcptnAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_uFaCoK5CEeWCgYcWSNgX5g")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header32 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_MJAZIK5DEeWCgYcWSNgX5g")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMXcptnAdvc")]
    [XmlElement(ElementName="PrtctdATMXcptnAdvc")]
    public ContentInformationType10? ProtectedATMExceptionAdvice { get; init; }
    
    /// <summary>
    /// Information related to exceptions occurring on the ATM.
    /// </summary>
    [IsoId("_4n370K5CEeWCgYcWSNgX5g")]
    [Description(@"Information related to exceptions occurring on the ATM.")]
    [DataMember(Name="ATMXcptnAdvc")]
    [XmlElement(ElementName="ATMXcptnAdvc")]
    public ATMExceptionAdvice1? ATMExceptionAdvice { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_PYXwwK5GEeWCgYcWSNgX5g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMExceptionAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMExceptionAdviceV01Document ToDocument()
    {
        return new ATMExceptionAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMExceptionAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMExceptionAdviceV01Document : IOuterDocument<ATMExceptionAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMExceptionAdviceV01"/> is required.
    /// </summary>
    public required ATMExceptionAdviceV01 Message { get; init; }
}
