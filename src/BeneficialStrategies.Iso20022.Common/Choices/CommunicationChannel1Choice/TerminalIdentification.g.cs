﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TerminalIdentification.  ISO2002 ID# _rbnlcA1DEeazkbJaoKTIIw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CommunicationChannel1Choice;

/// <summary>
/// CBRF identification of the terminal.
/// </summary>
public partial record TerminalIdentification : CommunicationChannel1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
