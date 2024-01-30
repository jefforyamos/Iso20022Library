﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BackupPaymentV07.  ISO2002 ID# _jwlbMRbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The BackupPayment message is sent by a member to the transaction administrator.
/// It is used to request a liquidity transfer from the member to another participant in the system when the user is in recovery mode.
/// Usage
/// Under very specific circumstances, the transaction administrator can accept direct input of transactions as part of its cash management functionalities. This possibility is available only when a declared incident has been reported to the transaction administrator This could be the case, for example, when the internal systems of the member are having problems sending out payments or when the continuity of the whole system is put at risk.
/// The purpose of the BackupPayment message is to prevent the consequences of a specific failure affecting not only the member experiencing problems but also its counterparties. Members can therefore input transactions directly in order to ensure the stability of the system and smooth exchanges.
/// At any time during the operating hours of the system, and under the agreed circumstances, the member can request a backup payment to be effected.
/// The member can request the transfer by identifying the following elements:
/// - party (account owner) that will receive the funds
/// - the financial institution that will receive the funds on behalf of the account owner
/// Based on the criteria received within the BackupPayment message, the transaction administrator will execute or reject the requested funds transfer.
/// The transaction administrator may send a Receipt message as a reply to the BackupPayment request.
/// To verify the outcome of the request, the member may submit a GetTransaction or GetAccount message with the appropriate search criteria.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BackupPayment message is sent by a member to the transaction administrator.|It is used to request a liquidity transfer from the member to another participant in the system when the user is in recovery mode.|Usage|Under very specific circumstances, the transaction administrator can accept direct input of transactions as part of its cash management functionalities. This possibility is available only when a declared incident has been reported to the transaction administrator This could be the case, for example, when the internal systems of the member are having problems sending out payments or when the continuity of the whole system is put at risk.|The purpose of the BackupPayment message is to prevent the consequences of a specific failure affecting not only the member experiencing problems but also its counterparties. Members can therefore input transactions directly in order to ensure the stability of the system and smooth exchanges.|At any time during the operating hours of the system, and under the agreed circumstances, the member can request a backup payment to be effected.|The member can request the transfer by identifying the following elements:|- party (account owner) that will receive the funds|- the financial institution that will receive the funds on behalf of the account owner|Based on the criteria received within the BackupPayment message, the transaction administrator will execute or reject the requested funds transfer.|The transaction administrator may send a Receipt message as a reply to the BackupPayment request.|To verify the outcome of the request, the member may submit a GetTransaction or GetAccount message with the appropriate search criteria.")]
public partial record BackupPaymentV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BckpPmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbMxbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader1 MessageHeader { get; init; }
    
    /// <summary>
    /// Identifies the original message identification.|This was formerly the PaymentInstructionReference.
    /// </summary>
    [IsoId("_jwlbNRbvEeiyVv5j1vf1VQ")]
    [Description(@"Identifies the original message identification.|This was formerly the PaymentInstructionReference.")]
    [DataMember(Name="OrgnlMsgId")]
    [XmlElement(ElementName="OrgnlMsgId")]
    public MessageHeader1? OriginalMessageIdentification { get; init; }
    
    /// <summary>
    /// Provides details on the execution and type of payment contained in the instruction.
    /// </summary>
    [IsoId("_jwlbNxbvEeiyVv5j1vf1VQ")]
    [Description(@"Provides details on the execution and type of payment contained in the instruction.")]
    [DataMember(Name="InstrInf")]
    [XmlElement(ElementName="InstrInf")]
    public PaymentInstruction13? InstructionInformation { get; init; }
    
    /// <summary>
    /// Quantity of cash that the transaction administrator transfers from one account to another.
    /// </summary>
    [IsoId("_jwlbORbvEeiyVv5j1vf1VQ")]
    [Description(@"Quantity of cash that the transaction administrator transfers from one account to another.")]
    [DataMember(Name="TrfdAmt")]
    [XmlElement(ElementName="TrfdAmt")]
    [Required]
    public required IAmount2Choice TransferredAmount { get; init; }
    
    /// <summary>
    /// Party that receives an amount of money from the debtor.
    /// </summary>
    [IsoId("_jwlbOxbvEeiyVv5j1vf1VQ")]
    [Description(@"Party that receives an amount of money from the debtor.")]
    [DataMember(Name="Cdtr")]
    [XmlElement(ElementName="Cdtr")]
    [Required]
    public required SystemMember3 Creditor { get; init; }
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("_jwlbPRbvEeiyVv5j1vf1VQ")]
    [Description(@"Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.")]
    [DataMember(Name="CdtrAgt")]
    [XmlElement(ElementName="CdtrAgt")]
    public SystemMember3? CreditorAgent { get; init; }
    
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// </summary>
    [IsoId("_jwlbPxbvEeiyVv5j1vf1VQ")]
    [Description(@"Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.")]
    [DataMember(Name="DbtrAgt")]
    [XmlElement(ElementName="DbtrAgt")]
    public SystemMember3? DebtorAgent { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbQRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BackupPaymentV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BackupPaymentV07Document ToDocument()
    {
        return new BackupPaymentV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BackupPaymentV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BackupPaymentV07Document : IOuterDocument<BackupPaymentV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.023.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BackupPaymentV07"/> is required.
    /// </summary>
    public required BackupPaymentV07 Message { get; init; }
}
