﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMWithdrawalCompletionAdviceV01.  ISO2002 ID# _-VAgcIqMEeSRT5rEzcAHEw.
//
namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// The ATMWithdrawalCompletionAdvice message is sent by an ATM to an acquirer or its agent to inform of the result of a withdrawal transaction at an ATM.
/// If the ATM is configured to only send negative completion, a generic completion message should be used instead of ATMCompletionAdvice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMWithdrawalCompletionAdvice message is sent by an ATM to an acquirer or its agent to inform of the result of a withdrawal transaction at an ATM.|If the ATM is configured to only send negative completion, a generic completion message should be used instead of ATMCompletionAdvice.")]
public partial record ATMWithdrawalCompletionAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMWdrwlCmpltnAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_Xl_cgIqNEeSRT5rEzcAHEw")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header21 Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_BzKz8IqOEeSRT5rEzcAHEw")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMWdrwlCmpltnAdvc")]
    [XmlElement(ElementName="PrtctdATMWdrwlCmpltnAdvc")]
    public ContentInformationType10? ProtectedATMWithdrawalCompletionAdvice { get; init; }
    
    /// <summary>
    /// Information related to the completion of a withdrawal transaction on the ATM.
    /// </summary>
    [IsoId("_PiQaIIqOEeSRT5rEzcAHEw")]
    [Description(@"Information related to the completion of a withdrawal transaction on the ATM.")]
    [DataMember(Name="ATMWdrwlCmpltnAdvc")]
    [XmlElement(ElementName="ATMWdrwlCmpltnAdvc")]
    public ATMWithdrawalCompletionAdvice1? ATMWithdrawalCompletionAdvice { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_abo-gIqOEeSRT5rEzcAHEw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMWithdrawalCompletionAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMWithdrawalCompletionAdviceV01Document ToDocument()
    {
        return new ATMWithdrawalCompletionAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMWithdrawalCompletionAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMWithdrawalCompletionAdviceV01Document : IOuterDocument<ATMWithdrawalCompletionAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.003.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMWithdrawalCompletionAdviceV01"/> is required.
    /// </summary>
    public required ATMWithdrawalCompletionAdviceV01 Message { get; init; }
}
