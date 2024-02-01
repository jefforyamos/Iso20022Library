﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Term1.  ISO2002 ID# _Q7yQ0dp-Ed-ak6NoX_4Aeg_528848853.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates one of the constraints of a range of business values.
/// </summary>
public partial record Term1
{
    #nullable enable
    
    /// <summary>
    /// Provides the relationship between a variable and a fixed value.
    /// </summary>
    public required Operator1Code Operator { get; init; } 
    /// <summary>
    /// Indicates the value.
    /// </summary>
    public required RateOrAbsoluteValue1Choice_ Value { get; init; } 
    
    #nullable disable
}
