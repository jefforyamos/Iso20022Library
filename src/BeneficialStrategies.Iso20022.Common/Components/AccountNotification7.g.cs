﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountNotification7.  ISO2002 ID# _fwKgVyGyEeKjd4jizyIDGA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the account notification.
/// </summary>
public partial record AccountNotification7
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account notification.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Provides details on the page number of the notification.
    /// Usage: The pagination of the notification is only allowed when agreed between the parties.
    /// </summary>
    public Pagination? NotificationPagination { get; init; } 
    /// <summary>
    /// Sequential number of the notification, as assigned by the account servicer. |Usage: The sequential number is increased incrementally for each notification sent electronically.
    /// </summary>
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    /// <summary>
    /// Legal sequential number of the notification, as assigned by the account servicer. It is increased incrementally for each notification sent.
    /// </summary>
    public IsoNumber? LegalSequenceNumber { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for which the account notification is issued.
    /// </summary>
    public DateTimePeriodDetails? FromToDate { get; init; } 
    /// <summary>
    /// Indicates whether the document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    /// <summary>
    /// Specifies the application used to generate the reporting.
    /// </summary>
    public ReportingSource1Choice_? ReportingSource { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account to which credit and debit entries are made.
    /// </summary>
    public required CashAccount25 Account { get; init; } 
    /// <summary>
    /// Identifies the parent account of the account for which the notification has been issued.
    /// </summary>
    public CashAccount24? RelatedAccount { get; init; } 
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    public AccountInterest2[] Interest { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides summary information on entries.
    /// </summary>
    public TotalTransactions4? TransactionsSummary { get; init; } 
    /// <summary>
    /// Set of elements used to specify an entry in the debit credit notification.|Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    public ReportEntry4[] Entry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details of the account notification.
    /// </summary>
    public IsoMax500Text? AdditionalNotificationInformation { get; init; } 
    
    #nullable disable
}
