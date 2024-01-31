﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMDepositCompletionAcknowledgementV01.  ISO2002 ID# _YEXqoK4REeWZgJQOa6iKCQ.
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
/// The ATMDepositCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMDepositCompletionAdvice message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMDepositCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMDepositCompletionAdvice message.")]
public partial record ATMDepositCompletionAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDpstCmpltnAck";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_ho578K4REeWZgJQOa6iKCQ")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header32 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_mHoKAK4REeWZgJQOa6iKCQ")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMDpstCmpltnAck")]
    [XmlElement(ElementName="PrtctdATMDpstCmpltnAck")]
    public ContentInformationType10? ProtectedATMDepositCompletionAcknowledgement { get; init; }
    
    /// <summary>
    /// Information related to the acknowledgement of an ATM deposit transaction from the ATM manager.
    /// </summary>
    [IsoId("_qZQXQK4REeWZgJQOa6iKCQ")]
    [Description(@"Information related to the acknowledgement of an ATM deposit transaction from the ATM manager.")]
    [DataMember(Name="ATMDpstCmpltnAck")]
    [XmlElement(ElementName="ATMDpstCmpltnAck")]
    public ATMDepositCompletionAcknowledgement1? ATMDepositCompletionAcknowledgement { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_DgzqgK4SEeWZgJQOa6iKCQ")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMDepositCompletionAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMDepositCompletionAcknowledgementV01Document ToDocument()
    {
        return new ATMDepositCompletionAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMDepositCompletionAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMDepositCompletionAcknowledgementV01Document : IOuterDocument<ATMDepositCompletionAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.015.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMDepositCompletionAcknowledgementV01"/> is required.
    /// </summary>
    public required ATMDepositCompletionAcknowledgementV01 Message { get; init; }
}
