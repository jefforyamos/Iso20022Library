﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _vZnKgTxJEeW5v6FXICU4Ew.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reporting7Choice;

/// <summary>
/// Third party reporting information expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IReporting7Choice
{
    public required Reporting1Code Value { get; init; }
}
