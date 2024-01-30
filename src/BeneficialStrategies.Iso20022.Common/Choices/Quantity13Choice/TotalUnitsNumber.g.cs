﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TotalUnitsNumber.  ISO2002 ID# _RWwlY_peEeCPwaG9zjUPNQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Quantity13Choice;

/// <summary>
/// Total quantity of securities to be settled.
/// </summary>
public partial record TotalUnitsNumber : IQuantity13Choice
{
    #nullable enable
    /// <summary>
    /// Quantity expressed as a number, eg, a number of shares.
    /// </summary>
    public required IsoDecimalNumber Unit { get; init; } 
    #nullable disable
}
