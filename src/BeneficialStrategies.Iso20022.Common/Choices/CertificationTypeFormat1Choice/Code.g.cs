﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q3BFmNp-Ed-ak6NoX_4Aeg_-801680904.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertificationTypeFormat1Choice;

/// <summary>
/// Standard code to specify the certification format required, that is, physical or electronic format.
/// </summary>
public partial record Code : CertificationTypeFormat1Choice_
{
    public required CertificationFormatType1Code Value { get; init; }
}
