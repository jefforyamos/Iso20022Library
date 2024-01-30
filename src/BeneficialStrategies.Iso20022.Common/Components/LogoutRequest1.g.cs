﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LogoutRequest1.  ISO2002 ID# _pv3ZIN6JEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Logout Request message.
/// </summary>
public partial record LogoutRequest1
{
    #nullable enable
    
    /// <summary>
    /// Indicates that the POI terminal is able to go(or have to go) to maintenance.
    /// </summary>
    public IsoTrueFalseIndicator? MaintenanceAllowed { get; init; } 
    
    #nullable disable
}
