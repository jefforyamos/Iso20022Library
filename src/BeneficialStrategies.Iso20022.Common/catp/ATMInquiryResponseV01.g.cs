﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMInquiryResponseV01.  ISO2002 ID# _ni6eUIqwEeSIDtZ76p6McQ.
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
/// The ATMInquiryResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the verifications requested in the ATMInquiryRequest.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMInquiryResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the verifications requested in the ATMInquiryRequest.")]
public partial record ATMInquiryResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMNqryRspn";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_wJq4wIqwEeSIDtZ76p6McQ")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header20 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_9db04IqwEeSIDtZ76p6McQ")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMNqryRspn")]
    [XmlElement(ElementName="PrtctdATMNqryRspn")]
    public ContentInformationType10? ProtectedATMInquiryResponse { get; init; }
    
    /// <summary>
    /// Information related to the response of an ATM inquiry from an ATM manager.
    /// </summary>
    [IsoId("_GOZUMIqxEeSIDtZ76p6McQ")]
    [Description(@"Information related to the response of an ATM inquiry from an ATM manager.")]
    [DataMember(Name="ATMNqryRspn")]
    [XmlElement(ElementName="ATMNqryRspn")]
    public ATMInquiryResponse1? ATMInquiryResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_MBxBAIqxEeSIDtZ76p6McQ")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMInquiryResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMInquiryResponseV01Document ToDocument()
    {
        return new ATMInquiryResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMInquiryResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMInquiryResponseV01Document : IOuterDocument<ATMInquiryResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMInquiryResponseV01"/> is required.
    /// </summary>
    public required ATMInquiryResponseV01 Message { get; init; }
}
