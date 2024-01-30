﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Account14.  ISO2002 ID# _jDPrIR6VEeOolf0-cMYhrw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
public partial record Account14
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentification1 Identification { get; init; } 
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    public IPartyIdentification2Choice? AccountServicer { get; init; } 
    
    #nullable disable
}
