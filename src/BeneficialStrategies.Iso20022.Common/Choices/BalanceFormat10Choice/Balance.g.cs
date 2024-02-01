﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Balance.  ISO2002 ID# _cjzu35KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat10Choice;

/// <summary>
/// Provides information about balance related to a corporate action.
/// </summary>
public partial record Balance : BalanceFormat10Choice_
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    public required Quantity21Choice_ QuantityChoice { get; init; } 
    #nullable disable
}
