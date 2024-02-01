﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HealthIndication.  ISO2002 ID# _3DBVOzANEeOKib24wnHaFg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice;

/// <summary>
/// Indicates if the goods have passed the health check.
/// </summary>
public partial record HealthIndication : CertifiedCharacteristics2Choice_
{
    public required IsoYesNoIndicator Value { get; init; }
}
