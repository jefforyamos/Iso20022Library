﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMKeyDownloadResponseV02.  ISO2002 ID# __AA4sa45EeWRfYPBaeOY8w.
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
/// The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.")]
public partial record ATMKeyDownloadResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldRspn";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("__AA4s645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header31 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("__AA4ta45EeWRfYPBaeOY8w")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMKeyDwnldRspn")]
    [XmlElement(ElementName="PrtctdATMKeyDwnldRspn")]
    public ContentInformationType10? ProtectedATMKeyDownloadResponse { get; init; }
    
    /// <summary>
    /// Information related to the response of an ATM key download from an ATM manager.
    /// </summary>
    [IsoId("__AA4t645EeWRfYPBaeOY8w")]
    [Description(@"Information related to the response of an ATM key download from an ATM manager.")]
    [DataMember(Name="ATMKeyDwnldRspn")]
    [XmlElement(ElementName="ATMKeyDwnldRspn")]
    public ATMKeyDownloadResponse2? ATMKeyDownloadResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("__AA4ua45EeWRfYPBaeOY8w")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMKeyDownloadResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMKeyDownloadResponseV02Document ToDocument()
    {
        return new ATMKeyDownloadResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMKeyDownloadResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMKeyDownloadResponseV02Document : IOuterDocument<ATMKeyDownloadResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMKeyDownloadResponseV02"/> is required.
    /// </summary>
    public required ATMKeyDownloadResponseV02 Message { get; init; }
}
