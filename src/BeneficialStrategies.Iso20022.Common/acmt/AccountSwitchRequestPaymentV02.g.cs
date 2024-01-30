﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchRequestPaymentV02.  ISO2002 ID# _7HT_d242EeiU9cctagi5ow.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline).")]
public partial record AccountSwitchRequestPaymentV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqPmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HT_eW42EeiU9cctagi5ow")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch and a response code to the original payment request.
    /// </summary>
    [IsoId("_7HT_e242EeiU9cctagi5ow")]
    [Description(@"Contains information about the details of the account switch and a response code to the original payment request.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_7HT_fW42EeiU9cctagi5ow")]
    [Description(@"Account held at the old account servicer being switched to the new account servicer.")]
    [DataMember(Name="OdAcct")]
    [XmlElement(ElementName="OdAcct")]
    [Required]
    public required CashAccount39 OldAccount { get; init; }
    
    /// <summary>
    /// Specific information relating to a request for payment, including details that enable the receiving account servicer to reconcile the payment to be received with the original payment request.
    /// </summary>
    [IsoId("_7HT_f242EeiU9cctagi5ow")]
    [Description(@"Specific information relating to a request for payment, including details that enable the receiving account servicer to reconcile the payment to be received with the original payment request.")]
    [DataMember(Name="CdtInstr")]
    [XmlElement(ElementName="CdtInstr")]
    [Required]
    public required CreditTransferTransaction33 CreditInstruction { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HT_gW42EeiU9cctagi5ow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchRequestPaymentV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchRequestPaymentV02Document ToDocument()
    {
        return new AccountSwitchRequestPaymentV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchRequestPaymentV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchRequestPaymentV02Document : IOuterDocument<AccountSwitchRequestPaymentV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.034.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchRequestPaymentV02"/> is required.
    /// </summary>
    public required AccountSwitchRequestPaymentV02 Message { get; init; }
}
