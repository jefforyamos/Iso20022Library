﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchInformationResponseV04.  ISO2002 ID# _KOk_v9cDEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner's account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner's account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer.")]
public partial record AccountSwitchInformationResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchInfRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_KOk_wdcDEeq_l4BJLVUF2Q")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_KOk_w9cDEeq_l4BJLVUF2Q")]
    [Description(@"Contains information about the details of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required SomeAccountSwitchDetailsRecord AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// New account to which the switch will be made (destination account).
    /// </summary>
    [IsoId("_KOk_xdcDEeq_l4BJLVUF2Q")]
    [Description(@"New account to which the switch will be made (destination account).")]
    [DataMember(Name="NewAcct")]
    [XmlElement(ElementName="NewAcct")]
    [Required]
    public required SomeNewAccountRecord NewAccount { get; init; }
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_KOk_x9cDEeq_l4BJLVUF2Q")]
    [Description(@"Account held at the old account servicer being switched to the new account servicer.")]
    [DataMember(Name="OdAcct")]
    [XmlElement(ElementName="OdAcct")]
    [Required]
    public required SomeOldAccountRecord OldAccount { get; init; }
    
    /// <summary>
    /// Details of debit payment arrangements associated with the old account. For example the payment may be a standing order, a bill payment arrangement or a future dated payment.
    /// </summary>
    [IsoId("_KOk_ydcDEeq_l4BJLVUF2Q")]
    [Description(@"Details of debit payment arrangements associated with the old account. For example the payment may be a standing order, a bill payment arrangement or a future dated payment.")]
    [DataMember(Name="PmtInstr")]
    [XmlElement(ElementName="PmtInstr")]
    public SomePaymentInstructionRecord? PaymentInstruction { get; init; }
    
    /// <summary>
    /// Details of a direct debit instruction associated with the old account.
    /// </summary>
    [IsoId("_KOk_y9cDEeq_l4BJLVUF2Q")]
    [Description(@"Details of a direct debit instruction associated with the old account.")]
    [DataMember(Name="DrctDbtInstr")]
    [XmlElement(ElementName="DrctDbtInstr")]
    public SomeDirectDebitInstructionRecord? DirectDebitInstruction { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KOk_zdcDEeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchInformationResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchInformationResponseV04Document ToDocument()
    {
        return new AccountSwitchInformationResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchInformationResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchInformationResponseV04Document : IOuterDocument<AccountSwitchInformationResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.028.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchInformationResponseV04"/> is required.
    /// </summary>
    public required AccountSwitchInformationResponseV04 Message { get; init; }
}
