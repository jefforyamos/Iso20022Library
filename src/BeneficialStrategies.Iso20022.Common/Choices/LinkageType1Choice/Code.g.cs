﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QtyREtp-Ed-ak6NoX_4Aeg_-1832047280.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LinkageType1Choice;

/// <summary>
/// Linkage type expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ILinkageType1Choice
{
    public required LinkageType1Code Value { get; init; }
}
