﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proxy.  ISO2002 ID# _7fsSgVtgEeSwKe7KuKvXhg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Proxy2Choice;

/// <summary>
/// Specifies the elements required to assign a proxy.
/// </summary>
public partial record Proxy : IProxy2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies how to register the proxy.
    /// </summary>
    public IsoMax350Text? RegistrationMethod { get; init; } 
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the intermediary.
    /// </summary>
    public IDateFormat29Choice? Deadline { get; init; } 
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the intermediary (STP mode).
    /// </summary>
    public IDateFormat29Choice? STPDeadline { get; init; } 
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the issuer.
    /// </summary>
    public IDateFormat29Choice? MarketDeadline { get; init; } 
    /// <summary>
    /// Specifies the proxy person that is authorised by the issuer.
    /// </summary>
    // public IReadOnlyCollection<Proxy5> AuthorisedProxy { get; init; }
    #nullable disable
}
