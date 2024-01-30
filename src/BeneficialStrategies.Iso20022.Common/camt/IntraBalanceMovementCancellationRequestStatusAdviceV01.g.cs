﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementCancellationRequestStatusAdviceV01.  ISO2002 ID# _DLtKezncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// The IntraBalanceMovementCancellationRequestStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement cancellation request previously sent by the account owner/requestor.
/// Usage:
/// The message may be used to:
/// - re-send a message previously sent (the sub-function of the message is "Duplicate")
/// - provide a third party with a copy of a message for information (the sub-function of the message is "Copy")
/// - re-send to a third party a copy of a message for information (the sub-function of the message is "CopyDuplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The IntraBalanceMovementCancellationRequestStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement cancellation request previously sent by the account owner/requestor.||Usage:|The message may be used to:|- re-send a message previously sent (the sub-function of the message is ""Duplicate"")|- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"")|- re-send to a third party a copy of a message for information (the sub-function of the message is ""CopyDuplicate"").")]
public partial record IntraBalanceMovementCancellationRequestStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntCxlReqStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtKgzncEem7JZMuWtwtsg")]
    [Description(@"Unambiguous identification of the message as known by the account servicer or settlement infrastructure.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    public DocumentIdentification51? Identification { get; init; }
    
    /// <summary>
    /// Reference of the original intra-balance movement cancellation request.
    /// </summary>
    [IsoId("_DLtKhTncEem7JZMuWtwtsg")]
    [Description(@"Reference of the original intra-balance movement cancellation request.")]
    [DataMember(Name="ReqRef")]
    [XmlElement(ElementName="ReqRef")]
    [Required]
    public required Identification14 RequestReference { get; init; }
    
    /// <summary>
    /// Unambiguous identification of a transaction as per the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_DLtKhzncEem7JZMuWtwtsg")]
    [Description(@"Unambiguous identification of a transaction as per the account owner (or the instructing party managing the account).")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required References14 TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_DLtKiTncEem7JZMuWtwtsg")]
    [Description(@"Provides details on the processing status of the transaction.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    [Required]
    public required IProcessingStatus69Choice ProcessingStatus { get; init; }
    
    /// <summary>
    /// Account to or from which an entry is made.
    /// </summary>
    [IsoId("_DLtKizncEem7JZMuWtwtsg")]
    [Description(@"Account to or from which an entry is made.")]
    [DataMember(Name="CshAcct")]
    [XmlElement(ElementName="CshAcct")]
    [Required]
    public required CashAccount38 CashAccount { get; init; }
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_G3mXojp8EemwKdP955WBJQ")]
    [Description(@"Party that legally owns the cash account.")]
    [DataMember(Name="CshAcctOwnr")]
    [XmlElement(ElementName="CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_G3mXozp8EemwKdP955WBJQ")]
    [Description(@"Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.")]
    [DataMember(Name="CshAcctSvcr")]
    [XmlElement(ElementName="CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }
    
    /// <summary>
    /// Intra-balance movement transaction details.
    /// </summary>
    [IsoId("_DLtKjTncEem7JZMuWtwtsg")]
    [Description(@"Intra-balance movement transaction details.")]
    [DataMember(Name="UndrlygIntraBal")]
    [XmlElement(ElementName="UndrlygIntraBal")]
    public IntraBalance5? UnderlyingIntraBalance { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtKjzncEem7JZMuWtwtsg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementCancellationRequestStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementCancellationRequestStatusAdviceV01Document ToDocument()
    {
        return new IntraBalanceMovementCancellationRequestStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraBalanceMovementCancellationRequestStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementCancellationRequestStatusAdviceV01Document : IOuterDocument<IntraBalanceMovementCancellationRequestStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.075.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementCancellationRequestStatusAdviceV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementCancellationRequestStatusAdviceV01 Message { get; init; }
}
