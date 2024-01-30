﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Name.  ISO2002 ID# _xPt7iGjNEeiRg5NzP0jkQg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice;

/// <summary>
/// Specifies the name by which a party is known and which is usually used to identify that party.
/// </summary>
public partial record Name : IUpdateLogPartyRecord1Choice
{
    #nullable enable
    /// <summary>
    /// Old value before the update.
    /// </summary>
    public required PartyName4 Old { get; init; } 
    /// <summary>
    /// New value after the update.
    /// </summary>
    public required PartyName4 New { get; init; } 
    #nullable disable
}
