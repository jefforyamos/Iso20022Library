﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _g7_wgF24EeiFXdiLi_Nf4A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfAmount1Choice;

/// <summary>
/// Type of amount expressed as a code.
/// </summary>
public partial record Code : ITypeOfAmount1Choice
{
    public required TaxWrapperAmountType1Code Value { get; init; }
}
