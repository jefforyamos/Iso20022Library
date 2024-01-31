﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MissingOrIncorrectInformation.  ISO2002 ID# _T-i3Mtp-Ed-ak6NoX_4Aeg_-1346615971.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification1Choice;

/// <summary>
/// Missing or incorrect information.
/// </summary>
public partial record MissingOrIncorrectInformation : IUnableToApplyJustification1Choice
{
    #nullable enable
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    public IReadOnlyCollection<UnableToApplyMissingInfo1Code> MissingInformation { get; init; } = [];
    /// <summary>
    /// Indicates the incorrect information.
    /// </summary>
    public IReadOnlyCollection<UnableToApplyIncorrectInfo2Code> IncorrectInformation { get; init; } = [];
    #nullable disable
}
