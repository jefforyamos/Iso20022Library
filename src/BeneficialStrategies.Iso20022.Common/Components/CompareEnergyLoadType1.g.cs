﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareEnergyLoadType1.  ISO2002 ID# _95CA8E6cEeyEpI66tm807w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a energy load type.
/// </summary>
public partial record CompareEnergyLoadType1
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public EnergyLoadType1Code? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public EnergyLoadType1Code? Value2 { get; init; } 
    
    #nullable disable
}
