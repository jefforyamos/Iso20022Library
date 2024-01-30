﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Equity.  ISO2002 ID# _Bv9MR2kwEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice;

/// <summary>
/// Details specific for Equity derivatives.
/// </summary>
public partial record Equity : IDerivative2Choice
{
    #nullable enable
    /// <summary>
    /// Underlying type of the equity derivative.
    /// </summary>
    public required IEquityDerivative3Choice UnderlyingType { get; init; } 
    /// <summary>
    /// Return parameter for the equity derivative.
    /// </summary>
    public EquityReturnParameter1Code? Parameter { get; init; } 
    #nullable disable
}
