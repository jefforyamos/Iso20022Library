﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMWithdrawalCompletionAcknowledgementV01.  ISO2002 ID# _P2qh4IqkEeS4a4abTJTSSw.
//
namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// The ATMWithdrawalCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMWithdrawalCompletionAdvice message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMWithdrawalCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMWithdrawalCompletionAdvice message.")]
public partial record ATMWithdrawalCompletionAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMWdrwlCmpltnAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_aFDBcIqkEeS4a4abTJTSSw")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_fAp_0IqkEeS4a4abTJTSSw")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMWdrwlCmpltnAck")]
    [XmlElement(ElementName="PrtctdATMWdrwlCmpltnAck")]
    public SomeProtectedATMWithdrawalCompletionAcknowledgementRecord? ProtectedATMWithdrawalCompletionAcknowledgement { get; init; }
    
    /// <summary>
    /// Information related to the acknowledgement of an ATM withdrawal transaction from the ATM manager.
    /// </summary>
    [IsoId("_yUgPEIqkEeS4a4abTJTSSw")]
    [Description(@"Information related to the acknowledgement of an ATM withdrawal transaction from the ATM manager.")]
    [DataMember(Name="ATMWdrwlCmpltnAck")]
    [XmlElement(ElementName="ATMWdrwlCmpltnAck")]
    public SomeATMWithdrawalCompletionAcknowledgementRecord? ATMWithdrawalCompletionAcknowledgement { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_2jjpcIqkEeS4a4abTJTSSw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMWithdrawalCompletionAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMWithdrawalCompletionAcknowledgementV01Document ToDocument()
    {
        return new ATMWithdrawalCompletionAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMWithdrawalCompletionAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMWithdrawalCompletionAcknowledgementV01Document : IOuterDocument<ATMWithdrawalCompletionAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.004.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMWithdrawalCompletionAcknowledgementV01"/> is required.
    /// </summary>
    public required ATMWithdrawalCompletionAcknowledgementV01 Message { get; init; }
}
