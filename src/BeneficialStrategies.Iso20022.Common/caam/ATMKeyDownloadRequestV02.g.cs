﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMKeyDownloadRequestV02.  ISO2002 ID# _jHkLIa45EeWRfYPBaeOY8w.
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
/// The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.")]
public partial record ATMKeyDownloadRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldReq";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_jHkLI645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header31 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_jHkLJa45EeWRfYPBaeOY8w")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMKeyDwnldReq")]
    [XmlElement(ElementName="PrtctdATMKeyDwnldReq")]
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; init; }
    
    /// <summary>
    /// Information related to the request of a key download from an ATM.
    /// </summary>
    [IsoId("_jHkLJ645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the request of a key download from an ATM.")]
    [DataMember(Name="ATMKeyDwnldReq")]
    [XmlElement(ElementName="ATMKeyDwnldReq")]
    public ATMKeyDownloadRequest2? ATMKeyDownloadRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_jHkLKa45EeWRfYPBaeOY8w")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMKeyDownloadRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMKeyDownloadRequestV02Document ToDocument()
    {
        return new ATMKeyDownloadRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMKeyDownloadRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMKeyDownloadRequestV02Document : IOuterDocument<ATMKeyDownloadRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMKeyDownloadRequestV02"/> is required.
    /// </summary>
    public required ATMKeyDownloadRequestV02 Message { get; init; }
}
