﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatementOfInvestmentFundTransactionsV02.  ISO2002 ID# _MccbotFSEd-BzquC8wXy7w_1866614208.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account servicer, for example, a transfer agent sends the StatementOfInvestmentFundTransactions message to the account owner, for example, an investment manager or its authorised representative to provide detailed transactions (increases and decreases) of holdings which occurred during a specified period of time.
/// Usage
/// The StatementOfInvestmentFundTransactions message is used to list the holdings transactions of a single (master) account or several sub-accounts.
/// This message should be used at a frequency agreed bi-laterally between the account servicer and the account owner.
/// This message must not be used in place of confirmation messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer, for example, a transfer agent sends the StatementOfInvestmentFundTransactions message to the account owner, for example, an investment manager or its authorised representative to provide detailed transactions (increases and decreases) of holdings which occurred during a specified period of time.|Usage|The StatementOfInvestmentFundTransactions message is used to list the holdings transactions of a single (master) account or several sub-accounts.|This message should be used at a frequency agreed bi-laterally between the account servicer and the account owner.|This message must not be used in place of confirmation messages.")]
public partial record StatementOfInvestmentFundTransactionsV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StmtOfInvstmtFndTxsV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Mccbo9FSEd-BzquC8wXy7w_-1980444025")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MccbpNFSEd-BzquC8wXy7w_1866614228")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MccbpdFSEd-BzquC8wXy7w_1866614269")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MccbptFSEd-BzquC8wXy7w_1866614630")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// General information related to the investment fund statement of transactions.
    /// </summary>
    [IsoId("_Mccbp9FSEd-BzquC8wXy7w_1866614287")]
    [Description(@"General information related to the investment fund statement of transactions.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement8 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Information related to an investment account.
    /// </summary>
    [IsoId("_MccbqNFSEd-BzquC8wXy7w_1866614322")]
    [Description(@"Information related to an investment account.")]
    [DataMember(Name="InvstmtAcctDtls")]
    [XmlElement(ElementName="InvstmtAcctDtls")]
    [Required]
    public required InvestmentAccount25 InvestmentAccountDetails { get; init; }
    
    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_McllkNFSEd-BzquC8wXy7w_1866614707")]
    [Description(@"Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.")]
    [DataMember(Name="TxOnAcct")]
    [XmlElement(ElementName="TxOnAcct")]
    public InvestmentFundTransactionsByFund2? TransactionOnAccount { get; init; }
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_McllkdFSEd-BzquC8wXy7w_1866614364")]
    [Description(@"The sub-account of the safekeeping or investment account.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SubAccountIdentification6? SubAccountDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_McllktFSEd-BzquC8wXy7w_1866614672")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatementOfInvestmentFundTransactionsV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatementOfInvestmentFundTransactionsV02Document ToDocument()
    {
        return new StatementOfInvestmentFundTransactionsV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatementOfInvestmentFundTransactionsV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatementOfInvestmentFundTransactionsV02Document : IOuterDocument<StatementOfInvestmentFundTransactionsV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatementOfInvestmentFundTransactionsV02"/> is required.
    /// </summary>
    public required StatementOfInvestmentFundTransactionsV02 Message { get; init; }
}
