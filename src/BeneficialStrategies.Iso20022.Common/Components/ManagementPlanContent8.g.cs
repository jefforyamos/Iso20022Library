﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ManagementPlanContent8.  ISO2002 ID# _4bxAIQ01EeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the management plan.
/// </summary>
public partial record ManagementPlanContent8
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Certificate chain of an asymmetric encryption keys for the encryption of temporary transport key of the key to inject.
    /// </summary>
    public IsoMax10KBinary[] KeyEnciphermentCertificate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    public TMSAction8[] Action { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
