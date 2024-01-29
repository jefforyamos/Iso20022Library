﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMDeviceReportV03.  ISO2002 ID# _viE_0bTlEeeQy4o2AayYHg.
//
namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// The ATMDeviceReport message is sent to an acquirer by an ATM, or forwarded by an agent, to report:
/// - The result of maintenance commands performed by the ATM,
/// - The components of the ATM,
/// - The status of the ATM components.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMDeviceReport message is sent to an acquirer by an ATM, or forwarded by an agent, to report:|- The result of maintenance commands performed by the ATM,|- The components of the ATM,|- The status of the ATM components.")]
public partial record ATMDeviceReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDvcRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_viFm4bTlEeeQy4o2AayYHg")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_viFm47TlEeeQy4o2AayYHg")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMDvcRpt")]
    [XmlElement(ElementName="PrtctdATMDvcRpt")]
    public SomeProtectedATMDeviceReportRecord? ProtectedATMDeviceReport { get; init; }
    
    /// <summary>
    /// Information related to the status report from an ATM device.
    /// </summary>
    [IsoId("_viFm5bTlEeeQy4o2AayYHg")]
    [Description(@"Information related to the status report from an ATM device.")]
    [DataMember(Name="ATMDvcRpt")]
    [XmlElement(ElementName="ATMDvcRpt")]
    public SomeATMDeviceReportRecord? ATMDeviceReport { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_viFm57TlEeeQy4o2AayYHg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMDeviceReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMDeviceReportV03Document ToDocument()
    {
        return new ATMDeviceReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMDeviceReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMDeviceReportV03Document : IOuterDocument<ATMDeviceReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.001.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMDeviceReportV03"/> is required.
    /// </summary>
    public required ATMDeviceReportV03 Message { get; init; }
}