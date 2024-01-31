﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMWithdrawalCompletionAdviceV02.  ISO2002 ID# _zg0SUa4JEeWZgJQOa6iKCQ.
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
/// The ATMWithdrawalCompletionAdvice message is sent by an ATM to an acquirer or its agent to inform of the result of a withdrawal transaction at an ATM.
/// If the ATM is configured to only send negative completion, a generic completion message should be used instead of ATMCompletionAdvice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMWithdrawalCompletionAdvice message is sent by an ATM to an acquirer or its agent to inform of the result of a withdrawal transaction at an ATM.|If the ATM is configured to only send negative completion, a generic completion message should be used instead of ATMCompletionAdvice.")]
public partial record ATMWithdrawalCompletionAdviceV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMWdrwlCmpltnAdvc";
    
    #nullable enable
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_zg0SU64JEeWZgJQOa6iKCQ")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header32 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_zg0SVa4JEeWZgJQOa6iKCQ")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMWdrwlCmpltnAdvc")]
    [XmlElement(ElementName="PrtctdATMWdrwlCmpltnAdvc")]
    public ContentInformationType10? ProtectedATMWithdrawalCompletionAdvice { get; init; }
    
    /// <summary>
    /// Information related to the completion of a withdrawal transaction on the ATM.
    /// </summary>
    [IsoId("_zg0SV64JEeWZgJQOa6iKCQ")]
    [Description(@"Information related to the completion of a withdrawal transaction on the ATM.")]
    [DataMember(Name="ATMWdrwlCmpltnAdvc")]
    [XmlElement(ElementName="ATMWdrwlCmpltnAdvc")]
    public ATMWithdrawalCompletionAdvice2? ATMWithdrawalCompletionAdvice { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_zg0SWa4JEeWZgJQOa6iKCQ")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMWithdrawalCompletionAdviceV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMWithdrawalCompletionAdviceV02Document ToDocument()
    {
        return new ATMWithdrawalCompletionAdviceV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMWithdrawalCompletionAdviceV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMWithdrawalCompletionAdviceV02Document : IOuterDocument<ATMWithdrawalCompletionAdviceV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMWithdrawalCompletionAdviceV02"/> is required.
    /// </summary>
    public required ATMWithdrawalCompletionAdviceV02 Message { get; init; }
}
