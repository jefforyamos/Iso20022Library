﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation26.  ISO2002 ID# _J-tsoeaVEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
public partial record CorporateActionGeneralInformation26
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public required IsoMax35Text CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required CorporateActionEventType3Choice_ EventType { get; init; } 
    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    public SecurityIdentification14? UnderlyingSecurityIdentification { get; init; } 
    
    #nullable disable
}
