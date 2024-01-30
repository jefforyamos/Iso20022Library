﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemMember3.  ISO2002 ID# _htb_MXSbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about a system and about a member of a system.
/// </summary>
public partial record SystemMember3
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public ISystemIdentification2Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public required IMemberIdentification3Choice MemberIdentification { get; init; } 
    
    #nullable disable
}
