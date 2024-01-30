﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Price11.  ISO2002 ID# _wKmy5yAZEeu4a6pNulzZ4Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type and information about a price.
/// </summary>
public partial record Price11
{
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    public required IYieldedOrValueType2Choice Type { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    public required IPriceRateOrAmount1Choice Value { get; init; } 
    
    #nullable disable
}
