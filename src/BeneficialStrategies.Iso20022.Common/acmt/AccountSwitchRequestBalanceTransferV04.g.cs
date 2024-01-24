﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchRequestBalanceTransferV04.  ISO2002 ID# _KOlm29cDEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchRequestBalanceTransfer message is sent by the new account servicer to the account servicer which previously held the account to request the transfer of the closing balance. This may be addressed to the new account or an alternate account nominated by the new account servicer. 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchRequestBalanceTransfer message is sent by the new account servicer to the account servicer which previously held the account to request the transfer of the closing balance. This may be addressed to the new account or an alternate account nominated by the new account servicer. ")]
public partial record AccountSwitchRequestBalanceTransferV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqBalTrf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_KOlm3dcDEeq_l4BJLVUF2Q")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_KOlm39cDEeq_l4BJLVUF2Q")]
    [Description(@"Contains information about the details of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required SomeAccountSwitchDetailsRecord AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Details of the new account set up with the new account servicer.
    /// Usage: If an Alternate Credit Account is not specified and the closing balance of the old account was positive then the payment of the outstanding balance should be made to this account.
    /// </summary>
    [IsoId("_KOlm4dcDEeq_l4BJLVUF2Q")]
    [Description(@"Details of the new account set up with the new account servicer.||Usage: If an Alternate Credit Account is not specified and the closing balance of the old account was positive then the payment of the outstanding balance should be made to this account.")]
    [DataMember(Name="NewAcct")]
    [XmlElement(ElementName="NewAcct")]
    [Required]
    public required SomeNewAccountRecord NewAccount { get; init; }
    
    /// <summary>
    /// Alternate beneficiary account for a payment made from the old account servicer to the new account servicer in the case of a positive closing balance of the old bank.
    /// </summary>
    [IsoId("_KOlm49cDEeq_l4BJLVUF2Q")]
    [Description(@"Alternate beneficiary account for a payment made from the old account servicer to the new account servicer in the case of a positive closing balance of the old bank.")]
    [DataMember(Name="NmntdAcct")]
    [XmlElement(ElementName="NmntdAcct")]
    public SomeNominatedAccountRecord? NominatedAccount { get; init; }
    
    /// <summary>
    /// Information that enables the receiving bank to reconcile the payment with the request.
    /// </summary>
    [IsoId("_KOlm5dcDEeq_l4BJLVUF2Q")]
    [Description(@"Information that enables the receiving bank to reconcile the payment with the request.")]
    [DataMember(Name="BalTrf")]
    [XmlElement(ElementName="BalTrf")]
    public SomeBalanceTransferRecord? BalanceTransfer { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KOlm59cDEeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchRequestBalanceTransferV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchRequestBalanceTransferV04Document ToDocument()
    {
        return new AccountSwitchRequestBalanceTransferV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchRequestBalanceTransferV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchRequestBalanceTransferV04Document : IOuterDocument<AccountSwitchRequestBalanceTransferV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.031.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchRequestBalanceTransferV04"/> is required.
    /// </summary>
    public required AccountSwitchRequestBalanceTransferV04 Message { get; init; }
}
