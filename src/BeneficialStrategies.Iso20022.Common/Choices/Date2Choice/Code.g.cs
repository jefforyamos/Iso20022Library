﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UdgCINopEeCWg-hsBVGrDA_1430086433.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Date2Choice;

/// <summary>
/// Date is defined using a code.
/// </summary>
public partial record Code : IDate2Choice
{
    public required DateType2Code Value { get; init; }
}
