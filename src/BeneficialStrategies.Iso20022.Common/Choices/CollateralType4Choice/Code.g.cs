﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Dydo85EkEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralType4Choice;

/// <summary>
/// Type of collateral expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ICollateralType4Choice
{
    public required CollateralType3Code Value { get; init; }
}
