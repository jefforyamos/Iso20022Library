﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EntryDetails1.  ISO2002 ID# _T8wuitp-Ed-ak6NoX_4Aeg_-120854203.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the underlying transaction(s) and/or batched entries.
/// </summary>
public partial record EntryDetails1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide details on batched transactions.
    /// </summary>
    public BatchInformation2? Batch { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the underlying transaction(s).
    /// </summary>
    public EntryTransaction2[] TransactionDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
