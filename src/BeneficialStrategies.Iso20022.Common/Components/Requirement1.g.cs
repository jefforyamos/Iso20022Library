﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Requirement1.  ISO2002 ID# _Ul4kA9p-Ed-ak6NoX_4Aeg_1931035123.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the margin requirements for the variation margin and optionally the segregated independent amount.
/// </summary>
public partial record Requirement1
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the margin requirements for the variation margin.
    /// </summary>
    public required MarginRequirement1 VariationMarginRequirement { get; init; } 
    /// <summary>
    /// Provides details about the margin requirements for the segregated independent amount.
    /// </summary>
    public MarginRequirement1? SegregatedIndependentAmountRequirement { get; init; } 
    
    #nullable disable
}
