﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Proxy3.  ISO2002 ID# _T4cPNNp-Ed-ak6NoX_4Aeg_-1419937890.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements that identify a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
public partial record Proxy3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    public IReadOnlyCollection<ProxyType2Code> ProxyType { get; init; } = [];
    /// <summary>
    /// Identifies an authorized proxy which has been assigned by the issuer of the meeting.
    /// </summary>
    public IndividualPerson16? PreassignedProxy { get; init; } 
    
    #nullable disable
}
