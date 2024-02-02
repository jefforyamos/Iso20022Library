﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNotificationSD9.  ISO2002 ID# _vkOZsb5NEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding notification general information details.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionNotificationSD9
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [DataMember]
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) created the announcement record.
    /// </summary>
    [DataMember]
    public required IsoISODateTime CreateDateAndTime { get; init; } 
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) last updated the announcement.
    /// </summary>
    [DataMember]
    public IsoISODateTime? UpdateDateAndTime { get; init; } 
    
    #nullable disable
}
