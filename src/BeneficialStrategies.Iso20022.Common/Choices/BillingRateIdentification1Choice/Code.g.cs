﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6Q10h5qlEeGSON8vddiWzQ_1326961211.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingRateIdentification1Choice;

/// <summary>
/// Specifies the billing rate identification code, as defined in an external code list.
/// </summary>
public partial record Code : IBillingRateIdentification1Choice
{
    public required ExternalBillingRateIdentification1Code Value { get; init; }
}
