﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProxyNotAllowed.  ISO2002 ID# _fCkac_M7EeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Proxy4Choice;

/// <summary>
/// Indicates that no proxy is allowed for a meeting.
/// </summary>
public partial record ProxyNotAllowed : IProxy4Choice
{
    public required ProxyNotAllowed1Code Value { get; init; }
}
