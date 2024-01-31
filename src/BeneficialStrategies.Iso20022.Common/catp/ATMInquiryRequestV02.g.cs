﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMInquiryRequestV02.  ISO2002 ID# _NsmBsa4VEeW_TaP-ygI0SQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.catp;


/// <summary>
/// This record is an implementation of the catp.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMInquiryRequest message is sent by an ATM to an ATM manager to request information about a customer (for example card, account).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMInquiryRequest message is sent by an ATM to an ATM manager to request information about a customer (for example card, account).")]
public partial record ATMInquiryRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMNqryReq";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_NsmBs64VEeW_TaP-ygI0SQ")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header31 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_NsmBta4VEeW_TaP-ygI0SQ")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMNqryReq")]
    [XmlElement(ElementName="PrtctdATMNqryReq")]
    public ContentInformationType10? ProtectedATMInquiryRequest { get; init; }
    
    /// <summary>
    /// Information related to the request of an inquiry from an ATM.
    /// </summary>
    [IsoId("_NsmBt64VEeW_TaP-ygI0SQ")]
    [Description(@"Information related to the request of an inquiry from an ATM.")]
    [DataMember(Name="ATMNqryReq")]
    [XmlElement(ElementName="ATMNqryReq")]
    public ATMInquiryRequest2? ATMInquiryRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_NsmBua4VEeW_TaP-ygI0SQ")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMInquiryRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMInquiryRequestV02Document ToDocument()
    {
        return new ATMInquiryRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMInquiryRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMInquiryRequestV02Document : IOuterDocument<ATMInquiryRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMInquiryRequestV02"/> is required.
    /// </summary>
    public required ATMInquiryRequestV02 Message { get; init; }
}
