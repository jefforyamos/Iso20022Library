﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountReport24.  ISO2002 ID# _MiVdFW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the account information or on a business error.
/// </summary>
public partial record AccountReport24
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentification4Choice_ AccountIdentification { get; init; } 
    /// <summary>
    /// Requested information on the account or business error when information has not been found.
    /// </summary>
    public required AccountOrBusinessError4Choice_ AccountOrError { get; init; } 
    
    #nullable disable
}
