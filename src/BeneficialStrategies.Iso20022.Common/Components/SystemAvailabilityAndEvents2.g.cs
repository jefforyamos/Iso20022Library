﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemAvailabilityAndEvents2.  ISO2002 ID# _xbmERZlcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details about the system availability and the related system events that might impact the availability.
/// </summary>
[DataContract]
[XmlType]
public partial record SystemAvailabilityAndEvents2
{
    #nullable enable
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? SystemCurrency { get; init; } 
    /// <summary>
    /// Time window of system activity.
    /// </summary>
    [DataMember]
    public TimePeriod1? SessionPeriod { get; init; } 
    /// <summary>
    /// Detailed information about an event occurring on a system, whether planned, such as the cut-off time for a specific type of eligible transfer, or unplanned (an unsolicited failure), as stipulated in the specifications of the system.
    /// </summary>
    [DataMember]
    public ValueList<SystemEvent2> Event { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information regarding the closure time of a system.
    /// </summary>
    [DataMember]
    public ValueList<SystemClosure2> ClosureInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
