﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8bgPeZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasis12Choice;

/// <summary>
/// Statement basis expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IStatementBasis12Choice
{
    public required StatementBasis2Code Value { get; init; }
}
