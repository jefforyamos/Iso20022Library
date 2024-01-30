﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NumberAndSumOfTransactions3.  ISO2002 ID# _tsYf4FkyEeGeoaLUQk__nA_492898549.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing the total sum of entries.
/// </summary>
public partial record NumberAndSumOfTransactions3
{
    #nullable enable
    
    /// <summary>
    /// Number of individual entries included in the report.
    /// </summary>
    public IsoMax15NumericText? NumberOfEntries { get; init; } 
    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    public IsoDecimalNumber? Sum { get; init; } 
    /// <summary>
    /// Resulting amount of the netted amounts for all debit and credit entries.
    /// </summary>
    public IsoDecimalNumber? TotalNetEntryAmount { get; init; } 
    /// <summary>
    /// Indicates whether the total net entry amount is a credit or a debit amount.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    #nullable disable
}
