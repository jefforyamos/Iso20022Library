﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VoteMethods2.  ISO2002 ID# _TjbBe9p-Ed-ak6NoX_4Aeg_1281456967.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of the different methods that can be used to vote.
/// </summary>
public partial record VoteMethods2
{
    #nullable enable
    
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    public IReadOnlyCollection<IsoAnyBICIdentifier> VoteThroughNetwork { get; init; } = [];
    /// <summary>
    /// Specifies the address where voting ballot can be sent.
    /// </summary>
    public IReadOnlyCollection<PostalAddress1> VoteByMail { get; init; } = [];
    /// <summary>
    /// Electronic address, e-mail or website, where a security holder can vote.
    /// </summary>
    public IReadOnlyCollection<CommunicationAddress4> ElectronicVote { get; init; } = [];
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    public IReadOnlyCollection<IsoMax35Text> VoteByTelephone { get; init; } = [];
    
    #nullable disable
}
