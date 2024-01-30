﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics13.  ISO2002 ID# _hUsuxcK4EeuFNp8LZAnorg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about number of transactions accepted and rejected and the reasons of the rejections.
/// </summary>
public partial record DetailedTransactionStatistics13
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
    /// Details on transactions rejected per error code.
    /// </summary>
    public RejectionReason53? TransactionsRejectionsReason { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
