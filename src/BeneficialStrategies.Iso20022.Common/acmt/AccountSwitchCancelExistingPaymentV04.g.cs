﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchCancelExistingPaymentV04.  ISO2002 ID# _KOlmwdcDEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchCancelExistingPayment message is sent by the new account servicer to the previous account servicer to identify which payment arrangements are to be cancelled on the account owner's account and when they are to be cancelled. This message is used during a partial switch of the account and may be sent multiple times to allow for the account parties to transfer different payment arrangements at different times during the switch. 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchCancelExistingPayment message is sent by the new account servicer to the previous account servicer to identify which payment arrangements are to be cancelled on the account owner's account and when they are to be cancelled. This message is used during a partial switch of the account and may be sent multiple times to allow for the account parties to transfer different payment arrangements at different times during the switch. ")]
public partial record AccountSwitchCancelExistingPaymentV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchCclExstgPmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_KOlmw9cDEeq_l4BJLVUF2Q")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_KOlmxdcDEeq_l4BJLVUF2Q")]
    [Description(@"Contains information about the details of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required SomeAccountSwitchDetailsRecord AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Details of the old account.
    /// </summary>
    [IsoId("_KOlmx9cDEeq_l4BJLVUF2Q")]
    [Description(@"Details of the old account.")]
    [DataMember(Name="OdAcct")]
    [XmlElement(ElementName="OdAcct")]
    [Required]
    public required SomeOldAccountRecord OldAccount { get; init; }
    
    /// <summary>
    /// Details of a debit payment arrangement associated with the old account. The payment may be a standing order, a bill payment arrangement or a future dated payment.
    /// </summary>
    [IsoId("_KOlmydcDEeq_l4BJLVUF2Q")]
    [Description(@"Details of a debit payment arrangement associated with the old account. The payment may be a standing order, a bill payment arrangement or a future dated payment.")]
    [DataMember(Name="PmtInstr")]
    [XmlElement(ElementName="PmtInstr")]
    public SomePaymentInstructionRecord? PaymentInstruction { get; init; }
    
    /// <summary>
    /// Details of a direct debit Instruction associated with the old account.
    /// </summary>
    [IsoId("_KOlmy9cDEeq_l4BJLVUF2Q")]
    [Description(@"Details of a direct debit Instruction associated with the old account.")]
    [DataMember(Name="DrctDbtInstr")]
    [XmlElement(ElementName="DrctDbtInstr")]
    public SomeDirectDebitInstructionRecord? DirectDebitInstruction { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KOlmzdcDEeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchCancelExistingPaymentV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchCancelExistingPaymentV04Document ToDocument()
    {
        return new AccountSwitchCancelExistingPaymentV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchCancelExistingPaymentV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchCancelExistingPaymentV04Document : IOuterDocument<AccountSwitchCancelExistingPaymentV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.029.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchCancelExistingPaymentV04"/> is required.
    /// </summary>
    public required AccountSwitchCancelExistingPaymentV04 Message { get; init; }
}
