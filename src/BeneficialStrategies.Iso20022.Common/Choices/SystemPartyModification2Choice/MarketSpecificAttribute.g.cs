﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarketSpecificAttribute.  ISO2002 ID# _yJhSrYv-Eei289CGNqs21g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice;

/// <summary>
/// Additional attributes defined by a central security depositary for a party.
/// </summary>
public partial record MarketSpecificAttribute : ISystemPartyModification2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the name of the market-specific attribute.
    /// </summary>
    public required IsoMax35Text Name { get; init; } 
    /// <summary>
    /// Specifies the value of the market-specific attribute.
    /// </summary>
    public required IsoMax350Text Value { get; init; } 
    #nullable disable
}
