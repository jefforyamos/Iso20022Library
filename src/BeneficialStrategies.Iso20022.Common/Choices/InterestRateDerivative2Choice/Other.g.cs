﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _xbbEc2lIEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateDerivative2Choice;

/// <summary>
/// Where contract type is different from swaps, swaptions, futures on swaps and forwards on a swap, this field is used.
/// </summary>
public partial record Other : InterestRateDerivative2Choice_
{
    public required UnderlyingInterestRateType3Code Value { get; init; }
}
