﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for VoteDirectlyToIssuer.  ISO2002 ID# _LM16IDT8Ee2tRf29bleifQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VoteThroughNetwork1Choice;

/// <summary>
/// Voting is performed by sending a vote message directly to the issuer. 
/// </summary>
public partial record VoteDirectlyToIssuer : IVoteThroughNetwork1Choice
{
    public required IsoAnyBICDec2014Identifier Value { get; init; }
}
