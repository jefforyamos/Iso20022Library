﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateCalculationDescription.  ISO2002 ID# _3b5pQFSTEempisJfoIfvvQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RequestShareHeldDate1Choice;

/// <summary>
/// Provides the description on how the date from which the shares have been held should be determined and communicated.
/// </summary>
public partial record DateCalculationDescription : RequestShareHeldDate1Choice_
{
    public required IsoMax350Text Value { get; init; }
}
