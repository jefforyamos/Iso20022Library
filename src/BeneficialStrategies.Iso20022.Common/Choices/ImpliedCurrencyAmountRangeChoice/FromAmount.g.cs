﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromAmount.  ISO2002 ID# _PU-EC9p-Ed-ak6NoX_4Aeg_-1606264842.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRangeChoice;

/// <summary>
/// Lower boundary of a range of amount values.
/// </summary>
public partial record FromAmount : ImpliedCurrencyAmountRangeChoice_
{
    #nullable enable
    /// <summary>
    /// Amount value of the range limit.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount BoundaryAmount { get; init; } 
    /// <summary>
    /// Indicates whether the boundary amount is included in the range of amount values.
    /// </summary>
    public required IsoYesNoIndicator Included { get; init; } 
    #nullable disable
}
