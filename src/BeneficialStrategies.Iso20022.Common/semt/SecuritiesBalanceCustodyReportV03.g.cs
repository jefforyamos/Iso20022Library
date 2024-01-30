﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesBalanceCustodyReportV03.  ISO2002 ID# _Mazc69FSEd-BzquC8wXy7w_-1520493983.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants, or
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer, or
/// - a transfer agent acting on behalf of a fund manager or an account owner's designated agent.
/// Usage
/// The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided.
/// The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis.
/// There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.
/// The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants, or|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.|Usage|The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided.|The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis.|There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesBalanceCustodyReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalCtdyRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information that uniquely identifies the SecuritiesBalanceCustodyReport message as known by the account servicer. When the report has multiple pages, one message equals one page. Therefore, Identification uniquely identifies the page.
    /// </summary>
    [IsoId("_Mazc7NFSEd-BzquC8wXy7w_-1520493922")]
    [Description(@"Information that uniquely identifies the SecuritiesBalanceCustodyReport message as known by the account servicer. When the report has multiple pages, one message equals one page. Therefore, Identification uniquely identifies the page.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification11 Identification { get; init; }
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_Mazc7dFSEd-BzquC8wXy7w_-1520493611")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_Mazc7tFSEd-BzquC8wXy7w_-1520493531")]
    [Description(@"Provides general information on the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement21 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Ma9N4NFSEd-BzquC8wXy7w_-1520493188")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public IPartyIdentification13Choice? AccountOwner { get; init; }
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.
    /// </summary>
    [IsoId("_Ma9N4dFSEd-BzquC8wXy7w_-1520493086")]
    [Description(@"Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.")]
    [DataMember(Name="AcctSvcr")]
    [XmlElement(ElementName="AcctSvcr")]
    public IPartyIdentification10Choice? AccountServicer { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Ma9N4tFSEd-BzquC8wXy7w_-1520492991")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount11 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_Ma9N49FSEd-BzquC8wXy7w_-1520492957")]
    [Description(@"Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.")]
    [DataMember(Name="IntrmyInf")]
    [XmlElement(ElementName="IntrmyInf")]
    public required IReadonlyCollection<Intermediary2> IntermediaryInformation { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_Ma9N5NFSEd-BzquC8wXy7w_-1520492697")]
    [Description(@"Net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="BalForAcct")]
    [XmlElement(ElementName="BalForAcct")]
    public AggregateBalanceInformation9? BalanceForAccount { get; init; }
    
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_Ma9N5dFSEd-BzquC8wXy7w_-1520492661")]
    [Description(@"Sub-account of the safekeeping or investment account.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SubAccountIdentification11? SubAccountDetails { get; init; }
    
    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_Ma9N5tFSEd-BzquC8wXy7w_-1520492619")]
    [Description(@"Total valuation amounts provided in the base currency of the account.")]
    [DataMember(Name="AcctBaseCcyTtlAmts")]
    [XmlElement(ElementName="AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement1? AccountBaseCurrencyTotalAmounts { get; init; }
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_Ma9N59FSEd-BzquC8wXy7w_-1520492258")]
    [Description(@"Party that originated the message, if other than the sender.")]
    [DataMember(Name="MsgOrgtr")]
    [XmlElement(ElementName="MsgOrgtr")]
    public IPartyIdentification10Choice? MessageOriginator { get; init; }
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_MbGX0NFSEd-BzquC8wXy7w_-1520492293")]
    [Description(@"Party that is the final destination of the message, if other than the receiver.")]
    [DataMember(Name="MsgRcpt")]
    [XmlElement(ElementName="MsgRcpt")]
    public IPartyIdentification10Choice? MessageRecipient { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesBalanceCustodyReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesBalanceCustodyReportV03Document ToDocument()
    {
        return new SecuritiesBalanceCustodyReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesBalanceCustodyReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesBalanceCustodyReportV03Document : IOuterDocument<SecuritiesBalanceCustodyReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesBalanceCustodyReportV03"/> is required.
    /// </summary>
    public required SecuritiesBalanceCustodyReportV03 Message { get; init; }
}
