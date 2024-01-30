﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInputResponse3.  ISO2002 ID# _INRIES8PEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input Response message.
/// </summary>
public partial record DeviceInputResponse3
{
    #nullable enable
    
    /// <summary>
    /// Result of display request.
    /// </summary>
    public OutputResult2? OutputResult { get; init; } 
    /// <summary>
    /// Result of input request.
    /// </summary>
    public required InputResult3 InputResult { get; init; } 
    
    #nullable disable
}
