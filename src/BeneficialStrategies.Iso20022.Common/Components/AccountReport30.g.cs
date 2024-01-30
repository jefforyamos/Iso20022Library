﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountReport30.  ISO2002 ID# _gN57wdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account report.
/// </summary>
public partial record AccountReport30
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account report.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Provides details on the page number of the report.
    /// Usage: The pagination of the report is only allowed when agreed between the parties.
    /// </summary>
    public Pagination1? ReportPagination { get; init; } 
    /// <summary>
    /// Sequential number of the report, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each report sent electronically.
    /// </summary>
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    /// <summary>
    /// Specifies the range of identification sequence numbers, as provided in the request.
    /// </summary>
    public ISequenceRange1Choice? ReportingSequence { get; init; } 
    /// <summary>
    /// Legal sequential number of the report, as assigned by the account servicer. It is increased incrementally for each report sent.
    /// </summary>
    public IsoNumber? LegalSequenceNumber { get; init; } 
    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    public IsoISODateTime? CreationDateTime { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for which the account report is issued.
    /// </summary>
    public DateTimePeriod1? FromToDate { get; init; } 
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
    public required CashAccount41 Account { get; init; } 
    /// <summary>
    /// Identifies the parent account of the account for which the report has been issued.
    /// </summary>
    public CashAccount40? RelatedAccount { get; init; } 
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    public AccountInterest4? Interest { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account at a specific point in time.
    /// </summary>
    public CashBalance8? Balance { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    public TotalTransactions6? TransactionsSummary { get; init; } 
    /// <summary>
    /// Specifies an entry in the report.
    /// Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// Usage Rule: In case of a Payments R-transaction the creditor / debtor referenced of the original payment initiation messages is also used for reporting of the R-transaction. The original debtor/creditor in the reporting of R-Transactions is not inverted. 
    /// Following elements all defined in the TransactionDetails in RelatedParties or RelatedAgents are impacted by this usage rule:
    /// Creditor, UltimateCreditor, CreditorAccount, CreditorAgent, Debtor, UltimateDebtor, DebtorAccount and DebtorAgent.
    /// </summary>
    public ReportEntry11? Entry { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details of the account report.
    /// </summary>
    public IsoMax500Text? AdditionalReportInformation { get; init; } 
    
    #nullable disable
}
