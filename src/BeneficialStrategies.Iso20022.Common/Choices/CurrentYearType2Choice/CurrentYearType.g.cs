﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrentYearType.  ISO2002 ID# _3gENYEXfEeGY6MkiuzuPOA_-654795239.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrentYearType2Choice;

/// <summary>
/// Current year ISA is an ISA that was issued during the current fiscal year.
/// </summary>
public partial record CurrentYearType : CurrentYearType2Choice_
{
    public required ISAType2Code Value { get; init; }
}
