﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cFGbMHhgEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemMemberType1Choice;

/// <summary>
/// System member type, in a coded form.
/// </summary>
public partial record Code : SystemMemberType1Choice_
{
    public required ExternalSystemMemberType1Code Value { get; init; }
}
