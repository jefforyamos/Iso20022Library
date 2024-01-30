﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatement5.  ISO2002 ID# _bP4JsR77EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account statement.
/// </summary>
public partial record AccountStatement5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account statement.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Provides details on the page number of the statement.
    /// Usage: The pagination of the statement is only allowed when agreed between the parties.
    /// </summary>
    public Pagination? StatementPagination { get; init; } 
    /// <summary>
    /// Sequential number of the statement, as assigned by the account servicer.|Usage: The sequential number is increased incrementally for each statement sent electronically.
    /// </summary>
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    /// <summary>
    /// Legal sequential number of the statement, as assigned by the account servicer. It is increased incrementally for each statement sent.||Usage: Where a paper statement is a legal requirement, it may have a number different from the electronic sequential number. Paper statements could for instance only be sent if movement on the account has taken place, whereas electronic statements could be sent at the end of each reporting period, regardless of whether movements have taken place or not.
    /// </summary>
    public IsoNumber? LegalSequenceNumber { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for which the account statement is issued.
    /// </summary>
    public DateTimePeriodDetails? FromToDate { get; init; } 
    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    public IReportingSource1Choice? ReportingSource { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    public required CashAccount25 Account { get; init; } 
    /// <summary>
    /// Identifies the parent account of the account for which the statement has been issued.
    /// </summary>
    public CashAccount24? RelatedAccount { get; init; } 
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    public AccountInterest3? Interest { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    public CashBalance3? Balance { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    public TotalTransactions4? TransactionsSummary { get; init; } 
    /// <summary>
    /// Specify an entry in the statement.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted. 
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    public ReportEntry7? Entry { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details of the account statement.
    /// </summary>
    public IsoMax500Text? AdditionalStatementInformation { get; init; } 
    
    #nullable disable
}
