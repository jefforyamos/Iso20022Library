﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatement1.  ISO2002 ID# _RT7rEdp-Ed-ak6NoX_4Aeg_-1421600546.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing further details on the account statement.
/// </summary>
public partial record AccountStatement1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account report, assigned by the account servicer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent electronically.
    /// </summary>
    public IsoNumber? ElectronicSequenceNumber { get; init; } 
    /// <summary>
    /// Legal sequential number of the report, assigned by the account servicer. It is increased incrementally for each report sent.||Usage: in those scenarios where eg a paper statement is a legal requirement, the paper statement may have a different numbering than the electronic sequential number. Paper statements can for instance only be sent if movement on the account has taken place, whereas electronic statements can be sent eg each day, regardless of whether movements have taken place or not.
    /// </summary>
    public IsoNumber? LegalSequenceNumber { get; init; } 
    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Range of time between the start date and the end date for which the account statement is issued.
    /// </summary>
    public DateTimePeriodDetails? FromToDate { get; init; } 
    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    public CopyDuplicate1Code? CopyDuplicateIndicator { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public required CashAccount13 Account { get; init; } 
    /// <summary>
    /// Identifies the parent account of the reported account.
    /// </summary>
    public CashAccount7? RelatedAccount { get; init; } 
    /// <summary>
    /// Provides general interest information that applies to the account at a particular moment in time.
    /// </summary>
    public AccountInterest1[] Interest { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements defining the balance(s).
    /// </summary>
    public CashBalance2[] Balance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of element providing summary information on entries.
    /// </summary>
    public TotalTransactions1? TransactionsSummary { get; init; } 
    /// <summary>
    /// Specifies the elements of an entry in the statement.||Usage: At least one reference must be provided to identify the entry and its underlying transaction(s).
    /// </summary>
    public StatementEntry1[] Entry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details on the account statement.
    /// </summary>
    public IsoMax500Text? AdditionalStatementInformation { get; init; } 
    
    #nullable disable
}
