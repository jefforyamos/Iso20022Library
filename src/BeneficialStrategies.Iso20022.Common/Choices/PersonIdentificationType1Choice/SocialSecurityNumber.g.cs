﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SocialSecurityNumber.  ISO2002 ID# _QEW5lNp-Ed-ak6NoX_4Aeg_-1180196178.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType1Choice;

/// <summary>
/// Number assigned by a social security agency.
/// </summary>
public partial record SocialSecurityNumber : PersonIdentificationType1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
