﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Energy.  ISO2002 ID# _BzEmOiYyEeWHeosc_5RQEw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice;

/// <summary>
/// Code list for energy type of commodities.
/// </summary>
public partial record Energy : AssetClassCommodity2Choice_
{
    public required AssetClassSubProductEnergyType1Code Value { get; init; }
}
