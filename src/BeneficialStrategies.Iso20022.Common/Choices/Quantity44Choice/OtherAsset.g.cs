﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherAsset.  ISO2002 ID# _cMLhAE3WEeidB49bWZiS0g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity44Choice;

/// <summary>
/// Quantity of asset to be transferred.
/// </summary>
public partial record OtherAsset : Quantity44Choice_
{
    public required IsoMax35Text Value { get; init; }
}
