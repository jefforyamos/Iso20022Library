﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification94.  ISO2002 ID# _bKhn8Y0PEeWRYffwL7E13A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity.
/// </summary>
public partial record GenericIdentification94
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    public PartyType3Code? Type { get; init; } 
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    public PartyType4Code? Issuer { get; init; } 
    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    public IsoMin2Max3AlphaText? Country { get; init; } 
    /// <summary>
    /// Name of the entity.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Access information to reach the target host.
    /// </summary>
    public NetworkParameters5? RemoteAccess { get; init; } 
    
    #nullable disable
}
