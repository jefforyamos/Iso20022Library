﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMDiagnosticRequestV02.  ISO2002 ID# _Vfn5Ua46EeWRfYPBaeOY8w.
//
namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// The ATMDiagnosticRequest message is sent from an ATM to an acquirer to verify the availability of the acquirer. The acquirer will also validate that this ATM is a valid ATM for its particular network.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMDiagnosticRequest message is sent from an ATM to an acquirer to verify the availability of the acquirer. The acquirer will also validate that this ATM is a valid ATM for its particular network.")]
public partial record ATMDiagnosticRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDgnstcReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_Vfn5U646EeWRfYPBaeOY8w")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header31 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_Vfn5Va46EeWRfYPBaeOY8w")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMDgnstcReq")]
    [XmlElement(ElementName="PrtctdATMDgnstcReq")]
    public ContentInformationType10? ProtectedATMDiagnosticRequest { get; init; }
    
    /// <summary>
    /// Information related to the request of a diagnostic from an ATM.
    /// </summary>
    [IsoId("_Vfn5V646EeWRfYPBaeOY8w")]
    [Description(@"Information related to the request of a diagnostic from an ATM.")]
    [DataMember(Name="ATMDgnstcReq")]
    [XmlElement(ElementName="ATMDgnstcReq")]
    public ATMDiagnosticRequest2? ATMDiagnosticRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_Vfn5Wa46EeWRfYPBaeOY8w")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMDiagnosticRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMDiagnosticRequestV02Document ToDocument()
    {
        return new ATMDiagnosticRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMDiagnosticRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMDiagnosticRequestV02Document : IOuterDocument<ATMDiagnosticRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMDiagnosticRequestV02"/> is required.
    /// </summary>
    public required ATMDiagnosticRequestV02 Message { get; init; }
}
