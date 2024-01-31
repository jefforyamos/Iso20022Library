﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Proxy1.  ISO2002 ID# _T4lZI9p-Ed-ak6NoX_4Aeg_1996983846.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements that identify a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
public partial record Proxy1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    public IReadOnlyCollection<ProxyType2Code> ProxyType { get; init; } = [];
    /// <summary>
    /// Identifies an authorized proxy which has been assigned by the issuer of the meeting.
    /// </summary>
    public IndividualPerson14? PreassignedProxy { get; init; } 
    
    #nullable disable
}
