﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _m-lyAWp7EemmaZLSPtWX5A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OptionParty3Choice;

/// <summary>
/// Option party expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IOptionParty3Choice
{
    public required OptionParty1Code Value { get; init; }
}
