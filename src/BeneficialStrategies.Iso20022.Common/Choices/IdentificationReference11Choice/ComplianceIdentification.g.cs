﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ComplianceIdentification.  ISO2002 ID# _Ad4rUNokEeC60axPepSq7g_-443438036.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference11Choice;

/// <summary>
/// Identification used to represent this transaction for compliance purposes.
/// </summary>
public partial record ComplianceIdentification : IdentificationReference11Choice_
{
    public required IsoMax35Text Value { get; init; }
}
