﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Derivative3.  ISO2002 ID# _63apwLbkEeaqL_M7XFD7PQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument where the value of the instrument derives from another financial instrument, benchmark or index.
/// </summary>
public partial record Derivative3
{
    #nullable enable
    
    /// <summary>
    /// Hierarchy of classification of a derivative.
    /// </summary>
    public required DerivativeClassification1 DerivativeClassification { get; init; } 
    /// <summary>
    /// Rate(s) that determine(s)) the value of the swap during the lifetime of the trade. Where both rates are fixed this does not need to be reported.
    /// </summary>
    public IReadOnlyCollection<DerivativeUnderlyingLeg1> DerivativeUnderlyingLeg { get; init; } = [];
    /// <summary>
    /// Option specific attributes.
    /// </summary>
    public Option14? OptionAttributes { get; init; } 
    
    #nullable disable
}
