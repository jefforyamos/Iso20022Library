﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount3.  ISO2002 ID# _Y-fwE_wLEeGHDMP28rpT3g_-1514769402.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
public partial record DetailedAmount3
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    public required TypeOfAmount2Code Type { get; init; } 
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Value { get; init; } 
    
    #nullable disable
}
