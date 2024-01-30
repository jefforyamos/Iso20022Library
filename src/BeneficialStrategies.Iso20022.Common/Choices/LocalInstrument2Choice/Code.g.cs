﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TF7NI9p-Ed-ak6NoX_4Aeg_365018928.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice;

/// <summary>
/// Specifies the local instrument, as published in an external local instrument code list.
/// </summary>
public partial record Code : ILocalInstrument2Choice
{
    public required ExternalLocalInstrument1Code Value { get; init; }
}
