﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EntitlementAssessment2.  ISO2002 ID# _TkeKUtp-Ed-ak6NoX_4Aeg_-271063564.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the parameters, such as dates, used to calculate the entitlement to vote at a general meeting.
/// </summary>
public partial record EntitlementAssessment2
{
    #nullable enable
    
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by an intermediary.
    /// </summary>
    public IDateFormat2Choice? SecuritiesBlockingDeadline { get; init; } 
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer. (STP mode).
    /// </summary>
    public IDateFormat2Choice? SecuritiesBlockingSTPDeadline { get; init; } 
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer.
    /// </summary>
    public IDateFormat2Choice? SecuritiesBlockingMarketDeadline { get; init; } 
    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    /// <summary>
    /// Date at which the positions are struck to note which parties will receive the entitlement, e.g. record date, book close date.
    /// </summary>
    public IDateFormat3Choice? EntitlementFixingDate { get; init; } 
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    public IDateFormat2Choice? RegistrationSecuritiesDeadline { get; init; } 
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    public IDateFormat2Choice? RegistrationSecuritiesSTPDeadline { get; init; } 
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    public IDateFormat2Choice? RegistrationSecuritiesMarketDeadline { get; init; } 
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary.
    /// </summary>
    public IDateFormat2Choice? RegistrationParticipationDeadline { get; init; } 
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    public IDateFormat2Choice? RegistrationParticipationSTPDeadline { get; init; } 
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is set by the issuer.
    /// </summary>
    public IDateFormat2Choice? RegistrationParticipationMarketDeadline { get; init; } 
    /// <summary>
    /// Number of votes assigned to one security.
    /// </summary>
    public IEntitlement1Choice? Entitlement { get; init; } 
    
    #nullable disable
}
