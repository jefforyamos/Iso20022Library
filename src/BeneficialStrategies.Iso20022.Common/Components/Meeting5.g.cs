﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Meeting5.  ISO2002 ID# _l-Zlq609EemDtrWpq90Ckg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the date and location(s) of a general meeting.
/// </summary>
public partial record Meeting5
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    public required DateFormat58Choice_ DateAndTime { get; init; } 
    /// <summary>
    /// Status of the meeting date.
    /// </summary>
    public MeetingDateStatus2Code? DateStatus { get; init; } 
    /// <summary>
    /// Indicates whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    public required IsoYesNoIndicator QuorumRequired { get; init; } 
    /// <summary>
    /// Location at which the meeting will take place.
    /// </summary>
    public LocationFormat1Choice_[] Location { get; init; } = [];
    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    public QuorumQuantity1Choice_? QuorumQuantity { get; init; } 
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    public IsoMax2048Text? URLAddress { get; init; } 
    
    #nullable disable
}
