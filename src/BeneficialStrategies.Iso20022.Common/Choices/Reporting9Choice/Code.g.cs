﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5mslk5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Reporting9Choice;

/// <summary>
/// Third party reporting information expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IReporting9Choice
{
    public required Reporting2Code Value { get; init; }
}
