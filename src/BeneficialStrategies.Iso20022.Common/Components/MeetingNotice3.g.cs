﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MeetingNotice3.  ISO2002 ID# _TkBeZtp-Ed-ak6NoX_4Aeg_-1325036860.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the shareholders meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
public partial record MeetingNotice3
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    public IsoMax35Text? MeetingIdentification { get; init; } 
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of security holders meeting.
    /// </summary>
    public required MeetingType2Code Type { get; init; } 
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    public IMeetingTypeClassification1Choice? Classification { get; init; } 
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    public IsoISODate? AnnouncementDate { get; init; } 
    /// <summary>
    /// Indicates whether physical participation to a meeting is required in order to be allowed to vote.
    /// </summary>
    public required IsoYesNoIndicator AttendanceRequired { get; init; } 
    /// <summary>
    /// Indicates how to order the attendance card or to give notice of attendance.
    /// </summary>
    public IsoMax350Text? AttendanceConfirmationInformation { get; init; } 
    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting. This deadline is set by an intermediary.
    /// </summary>
    public IDateFormat2Choice? AttendanceConfirmationDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting (STP mode). This deadline is set by an intermediary.
    /// </summary>
    public IDateFormat2Choice? AttendanceConfirmationSTPDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    public IDateFormat2Choice? AttendanceConfirmationMarketDeadline { get; init; } 
    /// <summary>
    /// Address to use over the www (HTTP) service where addtional information on the meeting may be found.
    /// </summary>
    public IsoMax256Text? AdditionalDocumentationURLAddress { get; init; } 
    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
    /// </summary>
    public IReadOnlyCollection<AdditionalRights1> AdditionalProcedureDetails { get; init; } = [];
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; } 
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; } 
    /// <summary>
    /// Choice to signalize whether proxy is allowed.
    /// </summary>
    public IProxy1Choice? ProxyChoice { get; init; } 
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    public IReadOnlyCollection<MeetingContactPerson1> ContactPersonDetails { get; init; } = [];
    /// <summary>
    /// Date on which a company publishes the results of its meeting.
    /// </summary>
    public IDateFormat3Choice? ResultPublicationDate { get; init; } 
    
    #nullable disable
}
