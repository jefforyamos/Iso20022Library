﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyInformation.  ISO2002 ID# _T-i3Mdp-Ed-ak6NoX_4Aeg_-1347537597.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification1Choice;

/// <summary>
/// When set to yes, indicates that all available information about the underlying payment instruction shall be sent.
/// </summary>
public partial record AnyInformation : IUnableToApplyJustification1Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
