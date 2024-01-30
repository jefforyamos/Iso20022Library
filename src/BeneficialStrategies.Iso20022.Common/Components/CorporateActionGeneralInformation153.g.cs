﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation153.  ISO2002 ID# _00VMnQVTEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
public partial record CorporateActionGeneralInformation153
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; } 
    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    public ICorporateActionEventProcessingType3Choice? EventProcessingType { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required ICorporateActionEventType89Choice EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    public required ICorporateActionMandatoryVoluntary4Choice MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    public required FinancialInstrumentAttributes85 UnderlyingSecurity { get; init; } 
    
    #nullable disable
}
