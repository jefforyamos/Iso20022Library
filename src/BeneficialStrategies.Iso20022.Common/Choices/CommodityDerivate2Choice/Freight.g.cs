﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Freight.  ISO2002 ID# _zwLKwWlHEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CommodityDerivate2Choice;

/// <summary>
/// Details specific to freight derivatives.
/// </summary>
public partial record Freight : ICommodityDerivate2Choice
{
    #nullable enable
    /// <summary>
    /// Specification of the size related to the freight sub type. Field to be populated when the base product field is equal to freight.
    /// </summary>
    public required IsoMax25Text Size { get; init; } 
    /// <summary>
    /// Details the specific route or time charter average. Field to be populated when the base product field is equal to freight.
    /// </summary>
    public required IsoMax25Text AverageTimeCharter { get; init; } 
    #nullable disable
}
