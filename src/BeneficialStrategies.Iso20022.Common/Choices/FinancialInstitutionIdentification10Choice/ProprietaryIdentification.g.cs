﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _Rou1F2AZEeiH9-hkDDXUHA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification10Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
/// </summary>
public partial record ProprietaryIdentification : IFinancialInstitutionIdentification10Choice
{
    public required IsoMax35Text Value { get; init; }
}
