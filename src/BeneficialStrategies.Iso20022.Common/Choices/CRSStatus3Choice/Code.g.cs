﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# __Xcm0UNeEeamLdeYEZm56w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CRSStatus3Choice;

/// <summary>
/// Common Reporting Standard (CRS) status expressed as a code.
/// </summary>
public partial record Code : CRSStatus3Choice_
{
    public required CRSStatus1Code Value { get; init; }
}
