﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTransactionPostingReportV05.  ISO2002 ID# _6IMaISRLEeON6sEIseGaUg.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope|An account servicer sends a SecuritiesTransactionPostingReport to an account owner to provide the details of increases and decreases of holdings which occurred during a specified period, for all or selected securities in the specified safekeeping account or sub-safekeeping account which the account servicer holds for the account owner. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|This message may be used as a trade date based or a settlement date based statement.|The message may also be used to: |- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesTransactionPostingReport to an account owner to provide the details of increases and decreases of holdings which occurred during a specified period, for all or selected securities in the specified safekeeping account or sub-safekeeping account which the account servicer holds for the account owner. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|This message may be used as a trade date based or a settlement date based statement.|The message may also be used to: |- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesTransactionPostingReportV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxPstngRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_6IMaLyRLEeON6sEIseGaUg")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_6IMaMSRLEeON6sEIseGaUg")]
    [Description(@"Provides general information on the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement11 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_6IMaMyRLEeON6sEIseGaUg")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public IPartyIdentification36Choice? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_6IMaNSRLEeON6sEIseGaUg")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_6IMaNyRLEeON6sEIseGaUg")]
    [Description(@"Reporting per financial instrument.")]
    [DataMember(Name="FinInstrmDtls")]
    [XmlElement(ElementName="FinInstrmDtls")]
    public FinancialInstrumentDetails17? FinancialInstrumentDetails { get; init; }
    
    /// <summary>
    /// Details at sub-account level.
    /// </summary>
    [IsoId("_6IMaOSRLEeON6sEIseGaUg")]
    [Description(@"Details at sub-account level.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SubAccountIdentification34? SubAccountDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTransactionPostingReportV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTransactionPostingReportV05Document ToDocument()
    {
        return new SecuritiesTransactionPostingReportV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTransactionPostingReportV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTransactionPostingReportV05Document : IOuterDocument<SecuritiesTransactionPostingReportV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.017.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTransactionPostingReportV05"/> is required.
    /// </summary>
    public required SecuritiesTransactionPostingReportV05 Message { get; init; }
}
