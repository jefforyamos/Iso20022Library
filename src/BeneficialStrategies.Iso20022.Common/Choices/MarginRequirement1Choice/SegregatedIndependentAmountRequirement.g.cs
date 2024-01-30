﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmountRequirement.  ISO2002 ID# _QmogMdp-Ed-ak6NoX_4Aeg_-911647050.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginRequirement1Choice;

/// <summary>
/// Provides details about the margin requirements for the segregated independent amount only.
/// </summary>
public partial record SegregatedIndependentAmountRequirement : IMarginRequirement1Choice
{
    #nullable enable
    /// <summary>
    /// Amount of new margin that will be delivered to one party by the other party after rounding, threshold and minimum transfer amount are taken into account.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DeliverMarginAmount { get; init; } 
    /// <summary>
    /// Amount of new margin that will be recalled to one party from the other party after rounding, threshold and minimum transfer amount are taken into account.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ReturnMarginAmount { get; init; } 
    #nullable disable
}
