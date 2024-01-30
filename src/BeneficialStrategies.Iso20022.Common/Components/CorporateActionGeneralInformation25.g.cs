﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation25.  ISO2002 ID# _D0Ad4eaVEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
public partial record CorporateActionGeneralInformation25
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
    /// Reference assigned by a court to a class action.
    /// </summary>
    public IsoMax35Text? ClassActionNumber { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required ICorporateActionEventType3Choice EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    public required ICorporateActionMandatoryVoluntary1Choice MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    public required SecurityIdentification14 UnderlyingSecurityIdentification { get; init; } 
    
    #nullable disable
}
