﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5W51-ZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceType13Choice;

/// <summary>
/// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
/// </summary>
public partial record Code : ISubBalanceType13Choice
{
    public required SecuritiesBalanceType12Code Value { get; init; }
}
