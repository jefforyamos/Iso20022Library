﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _O2CDA0EJEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType36Choice;

/// <summary>
/// Standard code to specify the type of tax rate.
/// </summary>
public partial record Code : RateType36Choice_
{
    public required DividendRateType1Code Value { get; init; }
}
