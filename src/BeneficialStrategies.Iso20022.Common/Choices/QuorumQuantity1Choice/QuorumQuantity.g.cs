﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuorumQuantity.  ISO2002 ID# _RDieptp-Ed-ak6NoX_4Aeg_-2055367828.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.QuorumQuantity1Choice;

/// <summary>
/// Minimum quantity of securities required to hold a meeting.
/// </summary>
public partial record QuorumQuantity : IQuorumQuantity1Choice
{
    public required IsoMax35Text Value { get; init; }
}
