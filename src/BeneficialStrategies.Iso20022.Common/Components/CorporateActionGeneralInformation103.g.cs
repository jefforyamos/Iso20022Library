﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation103.  ISO2002 ID# _c47qaZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionGeneralInformation103
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [DataMember]
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; } 
    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    [DataMember]
    public CorporateActionEventProcessingType3Choice_? EventProcessingType { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [DataMember]
    public required CorporateActionEventType35Choice_ EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [DataMember]
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [DataMember]
    public required FinancialInstrumentAttributes70 UnderlyingSecurity { get; init; } 
    
    #nullable disable
}
