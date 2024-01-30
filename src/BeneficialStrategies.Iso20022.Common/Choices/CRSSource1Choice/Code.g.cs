﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _J3oBAUNfEeamLdeYEZm56w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CRSSource1Choice;

/// <summary>
/// Source of the Common Reporting Standard (CRS) status expressed as a code.
/// </summary>
public partial record Code : ICRSSource1Choice
{
    public required CRSSourceStatus1Code Value { get; init; }
}
