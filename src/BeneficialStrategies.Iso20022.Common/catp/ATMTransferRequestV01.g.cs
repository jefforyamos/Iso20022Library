﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMTransferRequestV01.  ISO2002 ID# _vueJoK4rEeWLdt0vLARX2Q.
//
namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// The ATMTransferRequest message is sent by an ATM to an ATM manager to request the approval of a fund transfer at the ATM.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMTransferRequest message is sent by an ATM to an ATM manager to request the approval of a fund transfer at the ATM.")]
public partial record ATMTransferRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMTrfReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_7z5qYK4rEeWLdt0vLARX2Q")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header31 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_Ag7aMK4sEeWLdt0vLARX2Q")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMTrfReq")]
    [XmlElement(ElementName="PrtctdATMTrfReq")]
    public ContentInformationType10? ProtectedATMTransferRequest { get; init; }
    
    /// <summary>
    /// Information related to the request of a fund transfer from an ATM.
    /// </summary>
    [IsoId("_HwpwQK4sEeWLdt0vLARX2Q")]
    [Description(@"Information related to the request of a fund transfer from an ATM.")]
    [DataMember(Name="ATMTrfReq")]
    [XmlElement(ElementName="ATMTrfReq")]
    public ATMTransferRequest1? ATMTransferRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_A9cA8K41EeWpsoxRhdX-8A")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMTransferRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMTransferRequestV01Document ToDocument()
    {
        return new ATMTransferRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMTransferRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMTransferRequestV01Document : IOuterDocument<ATMTransferRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.016.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMTransferRequestV01"/> is required.
    /// </summary>
    public required ATMTransferRequestV01 Message { get; init; }
}
