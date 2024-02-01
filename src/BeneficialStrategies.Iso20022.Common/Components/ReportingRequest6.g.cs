﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportingRequest6.  ISO2002 ID# _eoT28dcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reporting request.
/// </summary>
public partial record ReportingRequest6
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the account reporting request.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Specifies the type of the requested reporting message.
    /// </summary>
    public required IsoMax35Text RequestedMessageNameIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account to which the reporting request refers.
    /// </summary>
    public CashAccount40? Account { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required Party40Choice_ AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    /// <summary>
    /// Specifies the requested reporting period.
    /// </summary>
    public ReportingPeriod5? ReportingPeriod { get; init; } 
    /// <summary>
    /// Specifies the range of identification sequence numbers which are being requested.
    /// </summary>
    public SequenceRange1Choice_? ReportingSequence { get; init; } 
    /// <summary>
    /// Identifies the transactions to be reported.
    /// </summary>
    public TransactionType2? RequestedTransactionType { get; init; } 
    /// <summary>
    /// Provides details on the requested balance reporting.
    /// </summary>
    public BalanceType13[] RequestedBalanceType { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
