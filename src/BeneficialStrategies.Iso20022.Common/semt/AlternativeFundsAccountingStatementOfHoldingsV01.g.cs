﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AlternativeFundsAccountingStatementOfHoldingsV01.  ISO2002 ID# _MeFaZtFSEd-BzquC8wXy7w_-255037867.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account servicer, for example, a transfer agent or administrator, sends the AlternativeFundsAccountingStatementOfHoldings message to the account owner, for example, an investment manager, custodian, fund manager or an account owner's designated agent, to provide detailed holdings of the portfolio at a specified moment in time.
/// There may be one or more parties between the account servicer and the account owner.
/// The message provides, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.
/// Usage
/// The AlternativeFundsAccountingStatementOfHoldings message is sent by the account servicer to the account owner:
/// - at a frequency agreed bilaterally between the account servicer and the account owner,
/// - as a response to a request for statement sent by the account owner.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer, for example, a transfer agent or administrator, sends the AlternativeFundsAccountingStatementOfHoldings message to the account owner, for example, an investment manager, custodian, fund manager or an account owner's designated agent, to provide detailed holdings of the portfolio at a specified moment in time.|There may be one or more parties between the account servicer and the account owner.|The message provides, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.|Usage|The AlternativeFundsAccountingStatementOfHoldings message is sent by the account servicer to the account owner:|- at a frequency agreed bilaterally between the account servicer and the account owner,|- as a response to a request for statement sent by the account owner.")]
public partial record AlternativeFundsAccountingStatementOfHoldingsV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AltrntvFndsAcctgStmtOfHldgs";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a technical application standpoint.
    /// </summary>
    [IsoId("_MeFaZ9FSEd-BzquC8wXy7w_-1816902269")]
    [Description(@"Reference that uniquely identifies a message from a technical application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MeFaaNFSEd-BzquC8wXy7w_-1627236244")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference4? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MeFaadFSEd-BzquC8wXy7w_1666808091")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public required IReadonlyCollection<AdditionalReference4> RelatedReference { get; init; } // Min=0, Max=2
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MeFaatFSEd-BzquC8wXy7w_1676967953")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_MeFaa9FSEd-BzquC8wXy7w_792258549")]
    [Description(@"The safekeeping or investment account.")]
    [DataMember(Name="InvstmtAcctDtls")]
    [XmlElement(ElementName="InvstmtAcctDtls")]
    [Required]
    public required InvestmentAccount30 InvestmentAccountDetails { get; init; }
    
    /// <summary>
    /// General information related to the hedge fund accounting statement of holdings.|.
    /// </summary>
    [IsoId("_MeOkUNFSEd-BzquC8wXy7w_-1677323565")]
    [Description(@"General information related to the hedge fund accounting statement of holdings.|.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement10 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that provides services to investors relating to financial products.
    /// </summary>
    [IsoId("_MeOkUdFSEd-BzquC8wXy7w_2081162206")]
    [Description(@"Party that provides services to investors relating to financial products.")]
    [DataMember(Name="RltdPtyDtls")]
    [XmlElement(ElementName="RltdPtyDtls")]
    public required IReadonlyCollection<Intermediary17> RelatedPartyDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_MeOkUtFSEd-BzquC8wXy7w_433316011")]
    [Description(@"Net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="BalForAcct")]
    [XmlElement(ElementName="BalForAcct")]
    public AggregateBalanceInformation5? BalanceForAccount { get; init; }
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_MeOkU9FSEd-BzquC8wXy7w_46360620")]
    [Description(@"Value of total holdings reported.")]
    [DataMember(Name="TtlVals")]
    [XmlElement(ElementName="TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_MeOkVNFSEd-BzquC8wXy7w_-108817498")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AlternativeFundsAccountingStatementOfHoldingsV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AlternativeFundsAccountingStatementOfHoldingsV01Document ToDocument()
    {
        return new AlternativeFundsAccountingStatementOfHoldingsV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AlternativeFundsAccountingStatementOfHoldingsV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AlternativeFundsAccountingStatementOfHoldingsV01Document : IOuterDocument<AlternativeFundsAccountingStatementOfHoldingsV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AlternativeFundsAccountingStatementOfHoldingsV01"/> is required.
    /// </summary>
    public required AlternativeFundsAccountingStatementOfHoldingsV01 Message { get; init; }
}
