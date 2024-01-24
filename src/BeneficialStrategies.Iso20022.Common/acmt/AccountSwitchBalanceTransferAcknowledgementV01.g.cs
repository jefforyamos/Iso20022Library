﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchBalanceTransferAcknowledgementV01.  ISO2002 ID# _ohwbQBMGEeSTk5fcu7tr9w.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchBalanceTransferAcknowledgement message is sent by the previous account servicer to the new account servicer in response to the AccountSwitchRequestBalanceTransfer message. It confirms the status of the old account and the balance of the account on closure. In the case of a negative closing balance, the old account servicer provides details of the nominated account to which payment should be made from the new account servicer.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchBalanceTransferAcknowledgement message is sent by the previous account servicer to the new account servicer in response to the AccountSwitchRequestBalanceTransfer message. It confirms the status of the old account and the balance of the account on closure. In the case of a negative closing balance, the old account servicer provides details of the nominated account to which payment should be made from the new account servicer.")]
public partial record AccountSwitchBalanceTransferAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchBalTrfAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_5evuIa5fEee17eDA_q0a9g")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_6zD1sa5fEee17eDA_q0a9g")]
    [Description(@"Contains information about the details of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required SomeAccountSwitchDetailsRecord AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Account held at the old Account Servicer being switched to the new Account Servicer.
    /// </summary>
    [IsoId("_xv5JUBMHEeSTk5fcu7tr9w")]
    [Description(@"Account held at the old Account Servicer being switched to the new Account Servicer.")]
    [DataMember(Name="OdAcct")]
    [XmlElement(ElementName="OdAcct")]
    [Required]
    public required SomeOldAccountRecord OldAccount { get; init; }
    
    /// <summary>
    /// Balance of the old account.
    /// </summary>
    [IsoId("_olEYgBMHEeSTk5fcu7tr9w")]
    [Description(@"Balance of the old account.")]
    [DataMember(Name="OdAcctBal")]
    [XmlElement(ElementName="OdAcctBal")]
    [Required]
    public required SomeOldAccountBalanceRecord OldAccountBalance { get; init; }
    
    /// <summary>
    /// Information that enables any payments made in connection with the fulfilment of an account switch to be reconciled by the relevant account servicer with the associated request.
    /// Usage: In the case of a negative closing balance of the old account, and where the old account servicer wishes any payment from the new account servicer to be addressed to an alternate account, this will be specified here.
    /// </summary>
    [IsoId("_GupTkA_TEeejZrQVdmNFGg")]
    [Description(@"Information that enables any payments made in connection with the fulfilment of an account switch to be reconciled by the relevant account servicer with the associated request.||Usage: In the case of a negative closing balance of the old account, and where the old account servicer wishes any payment from the new account servicer to be addressed to an alternate account, this will be specified here.")]
    [DataMember(Name="BalTrf")]
    [XmlElement(ElementName="BalTrf")]
    public SomeBalanceTransferRecord? BalanceTransfer { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wAy5IA8CEeeJ4ZumUkzG4Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchBalanceTransferAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchBalanceTransferAcknowledgementV01Document ToDocument()
    {
        return new AccountSwitchBalanceTransferAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchBalanceTransferAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchBalanceTransferAcknowledgementV01Document : IOuterDocument<AccountSwitchBalanceTransferAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.032.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchBalanceTransferAcknowledgementV01"/> is required.
    /// </summary>
    public required AccountSwitchBalanceTransferAcknowledgementV01 Message { get; init; }
}
