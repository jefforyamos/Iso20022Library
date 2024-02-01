﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EquityDerivative2.  ISO2002 ID# _PVUIgWlNEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Element to define an equity instrument.
/// </summary>
public partial record EquityDerivative2
{
    #nullable enable
    
    /// <summary>
    /// Underlying type of the equity derivative.
    /// </summary>
    public required EquityDerivative3Choice_ UnderlyingType { get; init; } 
    /// <summary>
    /// Return parameter for the equity derivative.
    /// </summary>
    public EquityReturnParameter1Code? Parameter { get; init; } 
    
    #nullable disable
}
