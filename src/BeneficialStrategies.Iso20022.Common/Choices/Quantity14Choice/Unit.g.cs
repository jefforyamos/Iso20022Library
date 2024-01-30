﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _QYSGhRgKEeKqWJINzXcn5g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Quantity14Choice;

/// <summary>
/// Total quantity of securities to be settled.
/// </summary>
public partial record Unit : IQuantity14Choice
{
    #nullable enable
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    // public IReadOnlyCollection<Unit5> UnitDetails { get; init; }
    #nullable disable
}
