﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EventInformation14.  ISO2002 ID# _Dkb2wQVSEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about event of a corporate action.
/// </summary>
[DataContract]
[XmlType]
public partial record EventInformation14
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [DataMember]
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Provides the reference of the linked official corporate action event.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [DataMember]
    public required CorporateActionEventType90Choice_ EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [DataMember]
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Provides information about the identification of the last notification.
    /// </summary>
    [DataMember]
    public NotificationIdentification6? LastNotificationIdentification { get; init; } 
    
    #nullable disable
}
