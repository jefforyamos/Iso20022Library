﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics10.  ISO2002 ID# _j31tca4cEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about number of transactions accepted and rejected and the reasons of the rejections.
/// </summary>
public partial record DetailedTransactionStatistics10
{
    #nullable enable
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total number of transactions accepted.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfTransactionsAccepted { get; init; } 
    /// <summary>
    /// Total number of transactions rejected.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfTransactionsRejected { get; init; } 
    /// <summary>
    /// Number of transactions rejected per error code.
    /// </summary>
    public RejectionReason47[] NumberOfTransactionsRejected { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
