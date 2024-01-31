﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Meeting2.  ISO2002 ID# _TKY2Y9p-Ed-ak6NoX_4Aeg_795834246.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the physical parameters of a shareholders meeting. Several dates and places can be defined for a meeting.
/// </summary>
public partial record Meeting2
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    public required IDateFormat2Choice DateAndTime { get; init; } 
    /// <summary>
    /// Indicates the status of a meeting date.
    /// </summary>
    public MeetingDateStatus1Code? DateStatus { get; init; } 
    /// <summary>
    /// Specifies whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    public required IsoYesNoIndicator QuorumRequired { get; init; } 
    /// <summary>
    /// Specifies location where meeting will take place.
    /// </summary>
    public IReadOnlyCollection<ILocationFormat1Choice> Location { get; init; } = [];
    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    public IsoMax35Text? QuorumQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity of securities, expressed as a percentage, required to hold a meeting.
    /// </summary>
    public IsoPercentageRate? QuorumQuantityPercentage { get; init; } 
    
    #nullable disable
}
