﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amount3.  ISO2002 ID# _9s6WsePHEea7_eMQH225xA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the amount in the reporting currency and optionally in the original currency.
/// </summary>
public partial record Amount3
{
    #nullable enable
    
    /// <summary>
    /// Amount expressed in the original currency.
    /// </summary>
    public IsoActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    /// <summary>
    /// Amount expressed in the reporting currency.
    /// </summary>
    public required IsoActiveCurrencyAndAmount ReportingAmount { get; init; } 
    
    #nullable disable
}
