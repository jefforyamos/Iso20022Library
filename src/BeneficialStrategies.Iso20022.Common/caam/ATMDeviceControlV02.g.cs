﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMDeviceControlV02.  ISO2002 ID# _caM7Qa45EeWRfYPBaeOY8w.
//
namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform.")]
public partial record ATMDeviceControlV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDvcCtrl";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_caM7Q645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_caM7Ra45EeWRfYPBaeOY8w")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMDvcCtrl")]
    [XmlElement(ElementName="PrtctdATMDvcCtrl")]
    public SomeProtectedATMDeviceControlRecord? ProtectedATMDeviceControl { get; init; }
    
    /// <summary>
    /// Information related to the control of an ATM device.
    /// </summary>
    [IsoId("_caM7R645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the control of an ATM device.")]
    [DataMember(Name="ATMDvcCtrl")]
    [XmlElement(ElementName="ATMDvcCtrl")]
    public SomeATMDeviceControlRecord? ATMDeviceControl { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_caM7Sa45EeWRfYPBaeOY8w")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMDeviceControlV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMDeviceControlV02Document ToDocument()
    {
        return new ATMDeviceControlV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMDeviceControlV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMDeviceControlV02Document : IOuterDocument<ATMDeviceControlV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMDeviceControlV02"/> is required.
    /// </summary>
    public required ATMDeviceControlV02 Message { get; init; }
}