﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentificationAndName5.  ISO2002 ID# _v5n0QSCSEeWJd9HF2tO7BA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the account expressed with a name and an account number.
/// </summary>
public partial record AccountIdentificationAndName5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentification4Choice_ Identification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    
    #nullable disable
}
