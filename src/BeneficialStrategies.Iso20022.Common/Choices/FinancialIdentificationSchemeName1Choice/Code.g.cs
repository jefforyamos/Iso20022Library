﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QALkMdp-Ed-ak6NoX_4Aeg_-2021925430.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialIdentificationSchemeName1Choice;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// </summary>
public partial record Code : IFinancialIdentificationSchemeName1Choice
{
    public required ExternalFinancialInstitutionIdentification1Code Value { get; init; }
}
