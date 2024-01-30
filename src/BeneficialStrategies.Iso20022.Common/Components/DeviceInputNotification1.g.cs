﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInputNotification1.  ISO2002 ID# _FGh4YN7DEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input notification message.
/// </summary>
public partial record DeviceInputNotification1
{
    #nullable enable
    
    /// <summary>
    /// Message main identifier.
    /// </summary>
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    public required ActionMessage6 OutputContent { get; init; } 
    
    #nullable disable
}
