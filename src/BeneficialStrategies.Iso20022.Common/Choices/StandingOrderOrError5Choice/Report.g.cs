﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _COWPUW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError5Choice;

/// <summary>
/// Reports either on the standing order or on a business error.
/// </summary>
public partial record Report : StandingOrderOrError5Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required StandingOrderIdentification4 StandingOrderIdentification { get; init; } 
    /// <summary>
    /// Requested information on the standing order or business error when information has not been found.
    /// </summary>
    public required StandingOrderOrError6Choice_ StandingOrderOrError { get; init; } 
    #nullable disable
}
