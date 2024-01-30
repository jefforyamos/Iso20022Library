﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QueuedTransactionsReport1.  ISO2002 ID# _kEa_wBt4Eeaiht5D4a9WSA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment funds transfer instructions from intraday queue.
/// </summary>
public partial record QueuedTransactionsReport1
{
    #nullable enable
    
    /// <summary>
    /// List of queue names/ identifiers.
    /// </summary>
    public required IsoMax35Text QueueType { get; init; } 
    /// <summary>
    /// Number of transactions in the queue.
    /// </summary>
    public IsoNumber? NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total amount of transactions in a given queue.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Transaction details sorted by counterparty account.
    /// </summary>
    public QueueTransaction1? BreakdownByCounterparty { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
