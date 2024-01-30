﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Account20.  ISO2002 ID# _MBS0ESFYEeWgV9SQSyaAog.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
public partial record Account20
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Institution servicing an account and assigning the account identifier to the account owner.
    /// </summary>
    public required IPartyIdentification70Choice AccountServicer { get; init; } 
    
    #nullable disable
}
