﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _c5WhXZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertificationTypeFormat4Choice;

/// <summary>
/// Standard code to specify the certification format required, that is, physical or electronic format.
/// </summary>
public partial record Code : CertificationTypeFormat4Choice_
{
    public required CertificationFormatType1Code Value { get; init; }
}
