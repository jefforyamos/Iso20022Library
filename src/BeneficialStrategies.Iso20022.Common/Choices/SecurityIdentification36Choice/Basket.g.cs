﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Basket.  ISO2002 ID# _POTEp4rpEeq91phomTRDDA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification36Choice;

/// <summary>
/// Identification of constituents for a basket of indexes.
/// </summary>
public partial record Basket : ISecurityIdentification36Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the structurer of the customer basket.
    /// </summary>
    public required IsoLEIIdentifier Structurer { get; init; } 
    /// <summary>
    /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
    /// </summary>
    public required IsoMax52Text Identification { get; init; } 
    /// <summary>
    /// Identifier of the underliers that represent the constituents of a custom basket.
    /// </summary>
    public BasketConstituents1? Constituents { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
