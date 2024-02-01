﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalTransactions3.  ISO2002 ID# _tshp1FkyEeGeoaLUQk__nA_-453924622.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide summary information on entries.
/// </summary>
public partial record TotalTransactions3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    public NumberAndSumOfTransactions3? TotalEntries { get; init; } 
    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; } 
    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; } 
    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    public TotalsPerBankTransactionCode2[] TotalEntriesPerBankTransactionCode { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
