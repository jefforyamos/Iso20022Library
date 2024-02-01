﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MissingOrIncorrectInformation.  ISO2002 ID# _T-i3Ndp-Ed-ak6NoX_4Aeg_-1089125167.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification2Choice;

/// <summary>
/// Set of elements used to indicate which information is missing or incorrect.
/// </summary>
public partial record MissingOrIncorrectInformation : UnableToApplyJustification2Choice_
{
    #nullable enable
    /// <summary>
    /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
    /// </summary>
    public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; } 
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    public IReadOnlyCollection<UnableToApplyMissingInformation2Code> MissingInformation { get; init; } = [];
    /// <summary>
    /// Indicates, in a coded form, the incorrect information.
    /// </summary>
    public IReadOnlyCollection<UnableToApplyIncorrectInformation3Code> IncorrectInformation { get; init; } = [];
    #nullable disable
}
