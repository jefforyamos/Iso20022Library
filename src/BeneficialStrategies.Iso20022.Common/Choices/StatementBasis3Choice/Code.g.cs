﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QrsmZdp-Ed-ak6NoX_4Aeg_-997314468.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasis3Choice;

/// <summary>
/// Statement basis expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IStatementBasis3Choice
{
    public required StatementBasis1Code Value { get; init; }
}
