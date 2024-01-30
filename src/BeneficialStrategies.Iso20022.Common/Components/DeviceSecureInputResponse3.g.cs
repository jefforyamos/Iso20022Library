﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceSecureInputResponse3.  ISO2002 ID# _-8ZsgS_FEeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a secure input request.
/// </summary>
public partial record DeviceSecureInputResponse3
{
    #nullable enable
    
    /// <summary>
    /// Cardholder PIN data when needed.
    /// </summary>
    public OnLinePIN8? CardholderPIN { get; init; } 
    
    #nullable disable
}
