﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchBalanceTransferAcknowledgementV02.  ISO2002 ID# _7HK1cW42EeiU9cctagi5ow.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchBalanceTransferAcknowledgement message is sent by the previous account servicer to the new account servicer in response to the AccountSwitchRequestBalanceTransfer message. It confirms the status of the old account and the balance of the account on closure. In the case of a negative closing balance, the old account servicer provides details of the nominated account to which payment should be made from the new account servicer.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchBalanceTransferAcknowledgement message is sent by the previous account servicer to the new account servicer in response to the AccountSwitchRequestBalanceTransfer message. It confirms the status of the old account and the balance of the account on closure. In the case of a negative closing balance, the old account servicer provides details of the nominated account to which payment should be made from the new account servicer.")]
public partial record AccountSwitchBalanceTransferAcknowledgementV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchBalTrfAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchBalanceTransferAcknowledgementV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchBalanceTransferAcknowledgementV02Document ToDocument()
    {
        return new AccountSwitchBalanceTransferAcknowledgementV02Document { Message = this };
    }
}

/// <summary>
/// The AccountSwitchBalanceTransferAcknowledgement message is sent by the previous account servicer to the new account servicer in response to the AccountSwitchRequestBalanceTransfer message. It confirms the status of the old account and the balance of the account on closure. In the case of a negative closing balance, the old account servicer provides details of the nominated account to which payment should be made from the new account servicer.
/// This is the outer document that contains <seealso cref="AccountSwitchBalanceTransferAcknowledgementV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchBalanceTransferAcknowledgementV02Document : IOuterDocument<AccountSwitchBalanceTransferAcknowledgementV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.032.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchBalanceTransferAcknowledgementV02"/> is required.
    /// </summary>
    public required AccountSwitchBalanceTransferAcknowledgementV02 Message { get; init; }
}
