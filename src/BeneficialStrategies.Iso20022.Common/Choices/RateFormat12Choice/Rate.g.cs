﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _uT61USqiEeObprHJy8Zrxg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat12Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : RateFormat12Choice_
{
    public required IsoBaseOne14Rate Value { get; init; }
}
