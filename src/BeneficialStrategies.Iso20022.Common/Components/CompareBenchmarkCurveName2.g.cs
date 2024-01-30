﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareBenchmarkCurveName2.  ISO2002 ID# _FQ6Gsax3Eem81-uIvTF5rQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a benchmark curve name.
/// </summary>
public partial record CompareBenchmarkCurveName2
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IBenchmarkCurveName10Choice? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public IBenchmarkCurveName10Choice? Value2 { get; init; } 
    
    #nullable disable
}
