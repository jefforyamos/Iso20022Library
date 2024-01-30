﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount1.  ISO2002 ID# _TFZvigEcEeCQm6a_G2yO_w_265407285.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
public partial record DetailedAmount1
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    public required TypeOfAmount2Code Type { get; init; } 
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Value { get; init; } 
    
    #nullable disable
}
