﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _sanRS_fZEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfPrice49Choice;

/// <summary>
/// Type of price expressed as an ISO 20022 code.
/// </summary>
public partial record Code : TypeOfPrice49Choice_
{
    public required TypeOfPrice17Code Value { get; init; }
}
