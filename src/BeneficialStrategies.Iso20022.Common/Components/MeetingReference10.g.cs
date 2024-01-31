﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MeetingReference10.  ISO2002 ID# _UP25gfKxEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a meeting.
/// </summary>
public partial record MeetingReference10
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification.
    /// </summary>
    public required IsoMax35Text MeetingIdentification { get; init; } 
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    public required IsoISODateTime MeetingDateAndTime { get; init; } 
    /// <summary>
    /// Type of meeting for which instructions are sent.
    /// </summary>
    public required MeetingType4Code Type { get; init; } 
    /// <summary>
    /// Classification type of the meeting.
    /// </summary>
    public IMeetingTypeClassification2Choice? Classification { get; init; } 
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    public IReadOnlyCollection<PostalAddress1> Location { get; init; } = [];
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    public IPartyIdentification129Choice? Issuer { get; init; } 
    
    #nullable disable
}
