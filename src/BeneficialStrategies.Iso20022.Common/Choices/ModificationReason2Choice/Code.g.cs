﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _0jrN8wlIEeGATtfOBToyew_613709740.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ModificationReason2Choice;

/// <summary>
/// Specifies the reason why the related instruction is modified, or the related modification request is executed.
/// </summary>
public partial record Code : IModificationReason2Choice
{
    public required ModifiedStatusReason1Code Value { get; init; }
}
