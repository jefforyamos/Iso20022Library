﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Zzxz8vF6EemQ7oqCO5NTQw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;

/// <summary>
/// Status, in a coded form.
/// </summary>
public partial record Code : ServiceStatus1Choice_
{
    public required ServiceRequestStatus1Code Value { get; init; }
}
