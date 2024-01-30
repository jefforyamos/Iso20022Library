﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardSecurityCapability1.  ISO2002 ID# _XRvwk2zqEemD24gVaMSpeA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cardholder verification capabilities performing the transaction at the point of service.
/// ISO 8583:87 bit 22-3, ISO 8583;93 bit 22-2, ISO 8583:2003 bit 27-2
/// </summary>
public partial record CardSecurityCapability1
{
    #nullable enable
    
    /// <summary>
    /// Defines the security capability.
    /// </summary>
    public required CardSecurityCapability1Code Capability { get; init; } 
    /// <summary>
    /// Other type of card security capability defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherCapability { get; init; } 
    
    #nullable disable
}
