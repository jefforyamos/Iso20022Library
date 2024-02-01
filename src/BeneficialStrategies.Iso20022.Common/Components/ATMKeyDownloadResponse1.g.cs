﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMKeyDownloadResponse1.  ISO2002 ID# _vxSi0ItREeST3ocKVc8_qA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM key download from an ATM manager.
/// </summary>
public partial record ATMKeyDownloadResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    public required ATMEnvironment7 Environment { get; init; } 
    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    public required ATMSecurityContext2 ATMSecurityContext { get; init; } 
    /// <summary>
    /// Random value from the ATM provided during a previous exchange.
    /// </summary>
    public IsoMax140Binary? ATMChallenge { get; init; } 
    /// <summary>
    /// Security parameters of the host downloading the key.
    /// </summary>
    public required SecurityParameters5 HostSecurityParameters { get; init; } 
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    public ATMCommand1[] Command { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
