﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate96.  ISO2002 ID# _YXWgaV99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate96
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    public IDateFormat49Choice? AnnouncementDate { get; init; } 
    /// <summary>
    /// Deadline by which the certification must be sent.
    /// </summary>
    public IDateFormat49Choice? CertificationDeadline { get; init; } 
    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    public IDateFormat41Choice? CourtApprovalDate { get; init; } 
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    public IDateFormat49Choice? EarlyClosingDate { get; init; } 
    /// <summary>
    /// Date/time at which an event is officially effective from the issuer's perspective.
    /// </summary>
    public IDateFormat41Choice? EffectiveDate { get; init; } 
    /// <summary>
    /// Date/time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution's ex date.
    /// </summary>
    public IDateFormat41Choice? EqualisationDate { get; init; } 
    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    public IDateFormat49Choice? FurtherDetailedAnnouncementDate { get; init; } 
    /// <summary>
    /// Date/time at which an index / rate / price / value will be determined.
    /// </summary>
    public IDateFormat49Choice? FixingDate { get; init; } 
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder's positions. This is also applicable to partial calls.
    /// </summary>
    public IDateFormat41Choice? LotteryDate { get; init; } 
    /// <summary>
    /// Date/time to which the maturity date of an interest bearing security is extended.
    /// </summary>
    public IDateFormat41Choice? NewMaturityDate { get; init; } 
    /// <summary>
    /// Date/time on which the bondholder's or shareholder's meeting will take place.
    /// </summary>
    public IDateFormat49Choice? MeetingDate { get; init; } 
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    public IDateFormat41Choice? MarginFixingDate { get; init; } 
    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    public IDateFormat41Choice? ProrationDate { get; init; } 
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    public IDateFormat41Choice? RecordDate { get; init; } 
    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    public IDateFormat49Choice? RegistrationDeadline { get; init; } 
    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    public IDateFormat49Choice? ResultsPublicationDate { get; init; } 
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    public IDateFormat49Choice? DeadlineToSplit { get; init; } 
    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    public IDateFormat49Choice? DeadlineForTaxBreakdownInstruction { get; init; } 
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    public IDateFormat49Choice? TradingSuspendedDate { get; init; } 
    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    public IDateFormat41Choice? UnconditionalDate { get; init; } 
    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    public IDateFormat41Choice? WhollyUnconditionalDate { get; init; } 
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    public IDateFormat41Choice? ExDividendDate { get; init; } 
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    public IDateFormat49Choice? OfficialAnnouncementPublicationDate { get; init; } 
    /// <summary>
    /// Date/time from which 'special processing' can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt 'special' after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    public IDateFormat41Choice? SpecialExDate { get; init; } 
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    public IDateFormat41Choice? GuaranteedParticipationDate { get; init; } 
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event, also known as Buyer Protection Deadline.
    /// </summary>
    public IDateFormat49Choice? ElectionToCounterpartyMarketDeadline { get; init; } 
    /// <summary>
    /// Date/time the account servicer has set as the deadline to respond, with instructions, prior to the election to counterparty market deadline.
    /// </summary>
    public IDateFormat49Choice? ElectionToCounterpartyResponseDeadline { get; init; } 
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    public IDateFormat41Choice? LapsedDate { get; init; } 
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    public IDateFormat41Choice? PaymentDate { get; init; } 
    /// <summary>
    /// Date/time by which the account owner must instruct directly another party, for example, to provide documentation to an issuer agent.
    /// </summary>
    public IDateFormat49Choice? ThirdPartyDeadline { get; init; } 
    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    public IDateFormat49Choice? EarlyThirdPartyDeadline { get; init; } 
    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    public IDateFormat41Choice? MarketClaimTrackingEndDate { get; init; } 
    /// <summary>
    /// Last day an investor can become a lead plaintiff.
    /// </summary>
    public IDateFormat49Choice? LeadPlaintiffDeadline { get; init; } 
    /// <summary>
    /// Date on which the action was filed at the applicable court.
    /// </summary>
    public IDateFormat41Choice? FilingDate { get; init; } 
    /// <summary>
    /// Date for the hearing between the plaintiff and defendant, as set by the court.
    /// </summary>
    public IDateFormat41Choice? HearingDate { get; init; } 
    
    #nullable disable
}
