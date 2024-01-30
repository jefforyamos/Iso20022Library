﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Account1.  ISO2002 ID# _Pofc89p-Ed-ak6NoX_4Aeg_-1748202398.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
public partial record Account1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification1? Identification { get; init; } 
    /// <summary>
    /// Institution servicing an account and assigning the account identifier to the account owner.
    /// </summary>
    public required IPartyIdentification1Choice AccountServicer { get; init; } 
    
    #nullable disable
}
