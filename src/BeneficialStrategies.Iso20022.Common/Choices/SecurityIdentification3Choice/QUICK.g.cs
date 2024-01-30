﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QUICK.  ISO2002 ID# _Qdr_l9p-Ed-ak6NoX_4Aeg_-722284921.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice;

/// <summary>
/// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
/// </summary>
public partial record QUICK : ISecurityIdentification3Choice
{
    public required IsoQUICKIdentifier Value { get; init; }
}
