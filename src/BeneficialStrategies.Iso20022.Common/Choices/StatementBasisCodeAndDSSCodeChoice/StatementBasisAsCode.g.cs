﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatementBasisAsCode.  ISO2002 ID# _Q7Cp8dp-Ed-ak6NoX_4Aeg_-1663061250.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasisCodeAndDSSCodeChoice;

/// <summary>
/// Statement basis expressed as a code.
/// </summary>
public partial record StatementBasisAsCode : IStatementBasisCodeAndDSSCodeChoice
{
    public required StatementBasis1Code Value { get; init; }
}
