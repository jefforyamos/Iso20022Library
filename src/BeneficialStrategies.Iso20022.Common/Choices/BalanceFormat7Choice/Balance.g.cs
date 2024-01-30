﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Balance.  ISO2002 ID# _cfsEr5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat7Choice;

/// <summary>
/// Provides information about balance related to a corporate action.
/// </summary>
public partial record Balance : IBalanceFormat7Choice
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    public required IQuantity21Choice QuantityChoice { get; init; } 
    #nullable disable
}
