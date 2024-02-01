﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MeetingReference5.  ISO2002 ID# _Tk62R9p-Ed-ak6NoX_4Aeg_-8393617.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements which allow to identify a meeting.
/// </summary>
public partial record MeetingReference5
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    public required IsoMax35Text MeetingIdentification { get; init; } 
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    public IsoISODateTime? MeetingDateAndTime { get; init; } 
    /// <summary>
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    public MeetingType2Code? Type { get; init; } 
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    public MeetingTypeClassification1Choice_? Classification { get; init; } 
    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    public PostalAddress1[] Location { get; init; } = [];
    
    #nullable disable
}
