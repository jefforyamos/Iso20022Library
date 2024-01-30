﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTransactionPostingReport002V10.  ISO2002 ID# _s9lnswVVEeqjd8n6wD9JVw.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// SecuritiesTransactionPostingReport is sent by an account servicer to an account owner to provide the details of increases and decreases of holdings which occurred during a specified period, for all or selected securities in the specified safekeeping account or sub-safekeeping account which the account servicer holds for the account owner. 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of its participants
/// - an agent (sub-custodian) acting on behalf of its global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// This message may be used as a trade date based or a settlement date based statement.
/// The message may also be used to: 
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|SecuritiesTransactionPostingReport is sent by an account servicer to an account owner to provide the details of increases and decreases of holdings which occurred during a specified period, for all or selected securities in the specified safekeeping account or sub-safekeeping account which the account servicer holds for the account owner. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of its participants|- an agent (sub-custodian) acting on behalf of its global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|This message may be used as a trade date based or a settlement date based statement.|The message may also be used to: |- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesTransactionPostingReport002V10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxPstngRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_s9lnwAVVEeqjd8n6wD9JVw")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// Provides general information to the report.
    /// </summary>
    [IsoId("_s9lnwgVVEeqjd8n6wD9JVw")]
    [Description(@"Provides general information to the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement82 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_s9lnxAVVEeqjd8n6wD9JVw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_s9lnxgVVEeqjd8n6wD9JVw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount40 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_s9lnyAVVEeqjd8n6wD9JVw")]
    [Description(@"Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.")]
    [DataMember(Name="IntrmyInf")]
    [XmlElement(ElementName="IntrmyInf")]
    public required IReadonlyCollection<Intermediary45> IntermediaryInformation { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_s9lnygVVEeqjd8n6wD9JVw")]
    [Description(@"Reporting per financial instrument.")]
    [DataMember(Name="FinInstrmDtls")]
    [XmlElement(ElementName="FinInstrmDtls")]
    public FinancialInstrumentDetails37? FinancialInstrumentDetails { get; init; }
    
    /// <summary>
    /// Details at sub-account level.
    /// </summary>
    [IsoId("_s9lnzAVVEeqjd8n6wD9JVw")]
    [Description(@"Details at sub-account level.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SubAccountIdentification61? SubAccountDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTransactionPostingReport002V10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTransactionPostingReport002V10Document ToDocument()
    {
        return new SecuritiesTransactionPostingReport002V10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTransactionPostingReport002V10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTransactionPostingReport002V10Document : IOuterDocument<SecuritiesTransactionPostingReport002V10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.017.002.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTransactionPostingReport002V10"/> is required.
    /// </summary>
    public required SecuritiesTransactionPostingReport002V10 Message { get; init; }
}
