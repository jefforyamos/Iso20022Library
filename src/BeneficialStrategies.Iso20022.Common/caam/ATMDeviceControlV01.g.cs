﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMDeviceControlV01.  ISO2002 ID# _YMegkItEEeSxlKlAGYErFg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caam;


/// <summary>
/// This record is an implementation of the caam.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform.")]
public partial record ATMDeviceControlV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDvcCtrl";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_gWLLkItEEeSxlKlAGYErFg")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header20 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_niPwsItEEeSxlKlAGYErFg")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMDvcCtrl")]
    [XmlElement(ElementName="PrtctdATMDvcCtrl")]
    public ContentInformationType10? ProtectedATMDeviceControl { get; init; }
    
    /// <summary>
    /// Information related to the control of an ATM device.
    /// </summary>
    [IsoId("_wvcgEItEEeSxlKlAGYErFg")]
    [Description(@"Information related to the control of an ATM device.")]
    [DataMember(Name="ATMDvcCtrl")]
    [XmlElement(ElementName="ATMDvcCtrl")]
    public ATMDeviceControl1? ATMDeviceControl { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_0rk-cItEEeSxlKlAGYErFg")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMDeviceControlV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMDeviceControlV01Document ToDocument()
    {
        return new ATMDeviceControlV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMDeviceControlV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMDeviceControlV01Document : IOuterDocument<ATMDeviceControlV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMDeviceControlV01"/> is required.
    /// </summary>
    public required ATMDeviceControlV01 Message { get; init; }
}
