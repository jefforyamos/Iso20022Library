﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalFeeReconciliation2.  ISO2002 ID# _fULtkaIAEeuiuNcvKhXmNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional fee reconciliation data.
/// </summary>
public partial record AdditionalFeeReconciliation2
{
    #nullable enable
    
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    public required ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    /// <summary>
    /// contains the list of additional fee types.
    /// </summary>
    public required TypeOfAmount21Code Type { get; init; } 
    /// <summary>
    /// Other amount type defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// ISO 8583:87 bit 82, 83, 84 & 85
    /// ISO 8583:93/2003 bit 109 & 110
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Number of transactions.
    /// </summary>
    public required IsoNumber Count { get; init; } 
    
    #nullable disable
}
