﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMPINManagementRequestV01.  ISO2002 ID# _SKd8QIq_EeSgLpgNvMAP2g.
//
namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// The ATMPINManagementRequest message is sent by an ATM to an ATM manager to request an operation on the cardholder PIN.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMPINManagementRequest message is sent by an ATM to an ATM manager to request an operation on the cardholder PIN.")]
public partial record ATMPINManagementRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMPINMgmtReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_bR2-kIq_EeSgLpgNvMAP2g")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header20 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_i3DOUIq_EeSgLpgNvMAP2g")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMPINMgmtReq")]
    [XmlElement(ElementName="PrtctdATMPINMgmtReq")]
    public ContentInformationType10? ProtectedATMPINManagementRequest { get; init; }
    
    /// <summary>
    /// Information related to the request of a PIN management from an ATM.
    /// </summary>
    [IsoId("_skj1cIq_EeSgLpgNvMAP2g")]
    [Description(@"Information related to the request of a PIN management from an ATM.")]
    [DataMember(Name="ATMPINMgmtReq")]
    [XmlElement(ElementName="ATMPINMgmtReq")]
    public ATMPINManagementRequest1? ATMPINManagementRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_xEJmMIq_EeSgLpgNvMAP2g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMPINManagementRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMPINManagementRequestV01Document ToDocument()
    {
        return new ATMPINManagementRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMPINManagementRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMPINManagementRequestV01Document : IOuterDocument<ATMPINManagementRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMPINManagementRequestV01"/> is required.
    /// </summary>
    public required ATMPINManagementRequestV01 Message { get; init; }
}
