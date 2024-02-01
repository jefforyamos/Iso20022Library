﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitReport7.  ISO2002 ID# _DAtgZ24-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the risk management limit or on a business error.
/// </summary>
public partial record LimitReport7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the limit on which information is requested.
    /// </summary>
    public required LimitIdentification5 LimitIdentification { get; init; } 
    /// <summary>
    /// Requested information on the limit or business error report when information has not been found.
    /// </summary>
    public required LimitOrError4Choice_ LimitOrError { get; init; } 
    
    #nullable disable
}
