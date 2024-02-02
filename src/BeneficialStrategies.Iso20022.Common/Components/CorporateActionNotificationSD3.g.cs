﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNotificationSD3.  ISO2002 ID# _1cnPoTL3EeKU9IrkkToqcw_-1946623556.
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
public partial record CorporateActionNotificationSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [DataMember]
    public required IsoMax350Text PlaceAndName { get; init; } 
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
