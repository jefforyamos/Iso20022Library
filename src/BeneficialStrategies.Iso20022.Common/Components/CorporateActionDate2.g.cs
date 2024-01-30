﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate2.  ISO2002 ID# _TeznNNp-Ed-ak6NoX_4Aeg_722709396.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate2
{
    #nullable enable
    
    /// <summary>
    /// Date on which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    public IDateFormat4Choice? RecordDate { get; init; } 
    /// <summary>
    /// Date on which a process is to be completed or becomes effective.
    /// </summary>
    public IDateFormat4Choice? EffectiveDate { get; init; } 
    /// <summary>
    /// Last day a holder can deliver the securities that it had previously protected.
    /// </summary>
    public IDateFormat4Choice? CoverExpirationDate { get; init; } 
    /// <summary>
    /// Date on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution's ex date.
    /// </summary>
    public IDateFormat4Choice? EqualisationDate { get; init; } 
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    public IDateFormat4Choice? MarginFixingDate { get; init; } 
    /// <summary>
    /// Date on which the lottery is run and applied to the holder's positions. This is also applicable to partial calls.
    /// </summary>
    public IDateFormat4Choice? LotteryDate { get; init; } 
    /// <summary>
    /// Last date a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    public IDateFormat4Choice? ProtectDate { get; init; } 
    /// <summary>
    /// Date upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    public IDateFormat4Choice? UnconditionalDate { get; init; } 
    /// <summary>
    /// Date on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    public IDateFormat4Choice? WhollyUnconditionalDate { get; init; } 
    /// <summary>
    /// Date on which results are published, eg, results of an offer.
    /// </summary>
    public IDateFormat4Choice? ResultsPublicationDate { get; init; } 
    /// <summary>
    /// Date/time upon which the High Court provided approval.
    /// </summary>
    public IDateFormat4Choice? CourtApprovalDate { get; init; } 
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    public IDateFormat4Choice? EarlyClosingDate { get; init; } 
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    public IDateFormat4Choice? ExDividendDate { get; init; } 
    /// <summary>
    /// Date/time at which an index rate will be determined.
    /// </summary>
    public IDateFormat4Choice? IndexFixingDate { get; init; } 
    /// <summary>
    /// Date on which an interest bearing financial instrument becomes due and principal is repaid by the issuer to the investor.
    /// </summary>
    public IDateFormat4Choice? MaturityDate { get; init; } 
    /// <summary>
    /// Date on which trading of a security is suspended as the result of an event.
    /// </summary>
    public IDateFormat4Choice? TradingSuspendedDate { get; init; } 
    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    public IDateFormat4Choice? CertificationDeadline { get; init; } 
    /// <summary>
    /// Date/time at which the securities will be redeemed (early) for payment of principal.
    /// </summary>
    public IDateFormat4Choice? RedemptionDate { get; init; } 
    /// <summary>
    /// Date on which instructions to register or registration details will be accepted.
    /// </summary>
    public IDateFormat4Choice? RegistrationDeadline { get; init; } 
    /// <summary>
    /// Date (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    public IDateFormat4Choice? ProrationDate { get; init; } 
    /// <summary>
    /// Date on until which tax breakdown instructions will be accepted.
    /// </summary>
    public IDateFormat4Choice? DeadlineForTaxBreakdownInstruction { get; init; } 
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    public IDateFormat4Choice? LapsedDate { get; init; } 
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    public IDateFormat4Choice? GuaranteedParticipationDate { get; init; } 
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.
    /// </summary>
    public IDateFormat4Choice? ElectionToCounterpartyDeadline { get; init; } 
    /// <summary>
    /// Date/time as from which 'special processing' can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, eg, a transaction dealt 'special' after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    public IDateFormat4Choice? SpecialExDate { get; init; } 
    
    #nullable disable
}
