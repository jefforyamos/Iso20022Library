﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _THaa5dp-Ed-ak6NoX_4Aeg_1223014481.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice;

/// <summary>
/// Category purpose, as published in an external category purpose code list.
/// </summary>
public partial record Code : ICategoryPurpose1Choice
{
    public required ExternalCategoryPurpose1Code Value { get; init; }
}
