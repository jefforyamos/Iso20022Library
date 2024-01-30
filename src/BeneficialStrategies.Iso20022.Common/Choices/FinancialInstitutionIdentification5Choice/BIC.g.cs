﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BIC.  ISO2002 ID# _TFehN9p-Ed-ak6NoX_4Aeg_1156630060.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice;

/// <summary>
/// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
/// </summary>
public partial record BIC : IFinancialInstitutionIdentification5Choice
{
    public required IsoBICIdentifier Value { get; init; }
}
