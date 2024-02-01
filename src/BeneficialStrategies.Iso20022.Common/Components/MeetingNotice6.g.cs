﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MeetingNotice6.  ISO2002 ID# _9YWLsfKvEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting, participation requirements and voting procedures.
/// </summary>
public partial record MeetingNotice6
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification
    /// </summary>
    public required IsoMax35Text MeetingIdentification { get; init; } 
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    /// <summary>
    /// Type of security holders meeting.
    /// </summary>
    public required MeetingType4Code Type { get; init; } 
    /// <summary>
    /// Classification of the meeting.
    /// </summary>
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; } 
    /// <summary>
    /// Indicates whether the meeting vote is held under the "one-man-one-vote" principle, also known as "per capita vote" whereby the shareholder attending the meeting has one vote only, regardless of the holding positions.
    /// </summary>
    public IsoYesNoIndicator? OneManOneVoteIndicator { get; init; } 
    /// <summary>
    /// Method of voting participation to the general meeting and related voting deadline per method of participation.
    /// </summary>
    public ParticipationMethod1[] Participation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information and conditions for physical attendance at the general meeting.
    /// </summary>
    public Attendance2? Attendance { get; init; } 
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    public IsoMax2048Text[] AdditionalDocumentationURLAddress { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, this may indicate where such information may be obtained.
    /// </summary>
    public AdditionalRights3[] AdditionalProcedureDetails { get; init; } = [];
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; } 
    /// <summary>
    /// Specifies the proxy or whether a proxy is not allowed.
    /// </summary>
    public Proxy4Choice_? ProxyChoice { get; init; } 
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    public MeetingContactPerson3[] ContactPersonDetails { get; init; } = [];
    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    public DateFormat3Choice_? ResultPublicationDate { get; init; } 
    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    /// <summary>
    /// Date at which the positions are struck to record which parties will receive the entitlement, for example, record date, book close date.
    /// </summary>
    public DateFormat1? EntitlementFixingDate { get; init; } 
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; } 
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    
    #nullable disable
}
