﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation128.  ISO2002 ID# _cJTyo5SfEeeh5JjedkaA_g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
public partial record CorporateActionGeneralInformation128
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
    /// Type of processing involved by a corporate action.
    /// </summary>
    public CorporateActionEventProcessingType2Choice_? EventProcessingType { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required CorporateActionEventType75Choice_ EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    public required CorporateActionMandatoryVoluntary3Choice_ MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    public required FinancialInstrumentAttributes79 UnderlyingSecurity { get; init; } 
    
    #nullable disable
}
