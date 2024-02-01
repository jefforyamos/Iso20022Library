﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountOwnerDocumentIdentification.  ISO2002 ID# _celQx5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentIdentification4Choice;

/// <summary>
/// Identification of the document assigned by the account owner.
/// </summary>
public partial record AccountOwnerDocumentIdentification : DocumentIdentification4Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
