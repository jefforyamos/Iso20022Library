﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryEvent.  ISO2002 ID# _RD_Kk9p-Ed-ak6NoX_4Aeg_553100137.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemEventType1Choice;

/// <summary>
/// Type of event, expressed as free text or a bilaterally agreed code.
/// </summary>
public partial record ProprietaryEvent : ISystemEventType1Choice
{
    public required IsoMax140Text Value { get; init; }
}
