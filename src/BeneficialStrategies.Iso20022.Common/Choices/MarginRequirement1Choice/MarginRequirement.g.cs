﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginRequirement.  ISO2002 ID# _QmogMNp-Ed-ak6NoX_4Aeg_202428352.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginRequirement1Choice;

/// <summary>
/// Provides details about the margin requirements for the variation margin and optionally the segregated independent amount.
/// </summary>
public partial record MarginRequirement : MarginRequirement1Choice_
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
