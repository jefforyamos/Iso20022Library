﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTransactionPostingReportV07.  ISO2002 ID# _V8fAcW6VEeat2-NFbXd1Pw.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesTransactionPostingReport to an account owner to provide the details of increases and decreases of holdings which occurred during a specified period, for all or selected securities in the specified safekeeping account or sub-safekeeping account which the account servicer holds for the account owner. 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// This message may be used as a trade date based or a settlement date based statement.
/// The message may also be used to: 
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends a SecuritiesTransactionPostingReport to an account owner to provide the details of increases and decreases of holdings which occurred during a specified period, for all or selected securities in the specified safekeeping account or sub-safekeeping account which the account servicer holds for the account owner. |The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|This message may be used as a trade date based or a settlement date based statement.|The message may also be used to: |- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesTransactionPostingReportV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxPstngRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_V8fAe26VEeat2-NFbXd1Pw")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required SomePaginationRecord Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_V8fAfW6VEeat2-NFbXd1Pw")]
    [Description(@"Provides general information on the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required SomeStatementGeneralDetailsRecord StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_V8fAf26VEeat2-NFbXd1Pw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public SomeAccountOwnerRecord? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_V8fAgW6VEeat2-NFbXd1Pw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SomeSafekeepingAccountRecord SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_V8fAg26VEeat2-NFbXd1Pw")]
    [Description(@"Reporting per financial instrument.")]
    [DataMember(Name="FinInstrmDtls")]
    [XmlElement(ElementName="FinInstrmDtls")]
    public SomeFinancialInstrumentDetailsRecord? FinancialInstrumentDetails { get; init; }
    
    /// <summary>
    /// Details at sub-account level.
    /// </summary>
    [IsoId("_V8fAhW6VEeat2-NFbXd1Pw")]
    [Description(@"Details at sub-account level.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SomeSubAccountDetailsRecord? SubAccountDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTransactionPostingReportV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTransactionPostingReportV07Document ToDocument()
    {
        return new SecuritiesTransactionPostingReportV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTransactionPostingReportV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTransactionPostingReportV07Document : IOuterDocument<SecuritiesTransactionPostingReportV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.017.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTransactionPostingReportV07"/> is required.
    /// </summary>
    public required SecuritiesTransactionPostingReportV07 Message { get; init; }
}
