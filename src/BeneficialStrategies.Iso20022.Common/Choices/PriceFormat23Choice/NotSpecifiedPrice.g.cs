﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedPrice.  ISO2002 ID# _ASFIo-wOEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat23Choice;

/// <summary>
/// Value of the price not specified.
/// </summary>
public partial record NotSpecifiedPrice : IPriceFormat23Choice
{
    public required PriceValueType10Code Value { get; init; }
}
