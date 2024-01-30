﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReturnExcessCash1.  ISO2002 ID# _hAr8AALpEeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the return excess cash type and the collateral currency.
/// </summary>
public partial record ReturnExcessCash1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the return excess cash type.
    /// </summary>
    public required IReturnExcessCash1Choice ReturnExcessCashType { get; init; } 
    /// <summary>
    /// Currency of the cash collateral.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode CashCollateralCurrency { get; init; } 
    
    #nullable disable
}
