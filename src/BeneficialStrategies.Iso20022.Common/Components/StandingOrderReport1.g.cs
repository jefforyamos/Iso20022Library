﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StandingOrderReport1.  ISO2002 ID# _COWPVW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the detailed attributes of a standing order.
/// </summary>
public partial record StandingOrderReport1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required StandingOrderIdentification4 StandingOrderIdentification { get; init; } 
    /// <summary>
    /// Requested information on the standing order or business error when information has not been found.
    /// </summary>
    public required IStandingOrderOrError6Choice StandingOrderOrError { get; init; } 
    
    #nullable disable
}
