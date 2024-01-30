﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalMandateIdentification.  ISO2002 ID# _to8xYlkyEeGeoaLUQk__nA_-657534883.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate2Choice;

/// <summary>
/// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
/// </summary>
public partial record OriginalMandateIdentification : IOriginalMandate2Choice
{
    public required IsoMax35Text Value { get; init; }
}
