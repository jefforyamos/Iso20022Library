﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AgreedAmountDetails.  ISO2002 ID# _Qm7bJtp-Ed-ak6NoX_4Aeg_-1292111974.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AgreedAmount1Choice;

/// <summary>
/// Provides details about the agreed amount for the variation margin and optionaly the segregated independent amount.
/// </summary>
public partial record AgreedAmountDetails : IAgreedAmount1Choice
{
    #nullable enable
    /// <summary>
    /// Provides details about the agreed amount for the variation margin.
    /// </summary>
    public required Amount1 VariationMarginAmount { get; init; } 
    /// <summary>
    /// Provides details about the agreed amount for the segregated independent amount.
    /// </summary>
    public Amount1? SegregatedIndependentAmount { get; init; } 
    #nullable disable
}
