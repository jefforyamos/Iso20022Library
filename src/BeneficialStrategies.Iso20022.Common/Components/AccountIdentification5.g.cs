﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification5.  ISO2002 ID# _nA01UvNBEeCuA5Tr22BnwA_-1479785847.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
public partial record AccountIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Description of the account.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Specifies the type of account.
    /// </summary>
    public GenericIdentification30? Type { get; init; } 
    
    #nullable disable
}
