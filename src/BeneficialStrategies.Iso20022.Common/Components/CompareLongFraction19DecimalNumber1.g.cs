﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareLongFraction19DecimalNumber1.  ISO2002 ID# _7PX6cExUEeywvc16MwOPfw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a number field represented as a 19 decimals.
/// </summary>
public partial record CompareLongFraction19DecimalNumber1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IsoLongFraction19DecimalNumber? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public IsoLongFraction19DecimalNumber? Value2 { get; init; } 
    
    #nullable disable
}
