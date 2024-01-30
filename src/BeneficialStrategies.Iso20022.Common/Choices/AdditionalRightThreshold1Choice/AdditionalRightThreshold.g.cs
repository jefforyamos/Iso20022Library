﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AdditionalRightThreshold.  ISO2002 ID# _RDrolNp-Ed-ak6NoX_4Aeg_2143895546.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalRightThreshold1Choice;

/// <summary>
/// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
/// </summary>
public partial record AdditionalRightThreshold : IAdditionalRightThreshold1Choice
{
    public required IsoMax35Text Value { get; init; }
}
