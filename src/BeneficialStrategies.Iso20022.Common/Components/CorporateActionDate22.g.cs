﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate22.  ISO2002 ID# _U9tvsPmYEeCWoI7cIKK3pQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_U9tvsPmYEeCWoI7cIKK3pQ")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_U9tvuvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncmntDt")]
    #endif
    [IsoXmlTag("AnncmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? AnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? AnnouncementDate { get; init; } 
    #else
    public DateFormat19Choice_? AnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    [IsoId("_U9tvxPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Certification Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnDdln")]
    #endif
    [IsoXmlTag("CertfctnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? CertificationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? CertificationDeadline { get; init; } 
    #else
    public DateFormat19Choice_? CertificationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    [IsoId("_U9tvzvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Court Approval Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrtApprvlDt")]
    #endif
    [IsoXmlTag("CrtApprvlDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? CourtApprovalDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? CourtApprovalDate { get; init; } 
    #else
    public DateFormat19Choice_? CourtApprovalDate { get; set; } 
    #endif
    
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_U9tv2PmYEeCWoI7cIKK3pQ")]
    [DisplayName("Early Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyClsgDt")]
    #endif
    [IsoXmlTag("EarlyClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? EarlyClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? EarlyClosingDate { get; init; } 
    #else
    public DateFormat19Choice_? EarlyClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an event is officially effective from the issuer&apos;s perspective.
    /// </summary>
    [IsoId("_U9tv4vmYEeCWoI7cIKK3pQ")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? EffectiveDate { get; init; } 
    #else
    public DateFormat19Choice_? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_U9tv7PmYEeCWoI7cIKK3pQ")]
    [DisplayName("Equalisation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqulstnDt")]
    #endif
    [IsoXmlTag("EqulstnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? EqualisationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? EqualisationDate { get; init; } 
    #else
    public DateFormat19Choice_? EqualisationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    [IsoId("_U9tv9vmYEeCWoI7cIKK3pQ")]
    [DisplayName("Further Detailed Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrthrDtldAnncmntDt")]
    #endif
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    #else
    public DateFormat19Choice_? FurtherDetailedAnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an index / rate / price / value will be determined.
    /// </summary>
    [IsoId("_U9twAPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxgDt")]
    #endif
    [IsoXmlTag("FxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? FixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? FixingDate { get; init; } 
    #else
    public DateFormat19Choice_? FixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_U9twCvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Lottery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryDt")]
    #endif
    [IsoXmlTag("LtryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? LotteryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? LotteryDate { get; init; } 
    #else
    public DateFormat19Choice_? LotteryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time to which the maturity date of an interest bearing security is extended.
    /// </summary>
    [IsoId("_U9twFPmYEeCWoI7cIKK3pQ")]
    [DisplayName("New Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewMtrtyDt")]
    #endif
    [IsoXmlTag("NewMtrtyDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? NewMaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? NewMaturityDate { get; init; } 
    #else
    public DateFormat19Choice_? NewMaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the bondholder&apos;s or shareholder&apos;s meeting will take place.
    /// </summary>
    [IsoId("_U9twGPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Meeting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgDt")]
    #endif
    [IsoXmlTag("MtgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? MeetingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? MeetingDate { get; init; } 
    #else
    public DateFormat19Choice_? MeetingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_U9twIvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Margin Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnFxgDt")]
    #endif
    [IsoXmlTag("MrgnFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? MarginFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? MarginFixingDate { get; init; } 
    #else
    public DateFormat19Choice_? MarginFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_U9twLPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Proration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnDt")]
    #endif
    [IsoXmlTag("PrratnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? ProrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? ProrationDate { get; init; } 
    #else
    public DateFormat19Choice_? ProrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_U9twNvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdDt")]
    #endif
    [IsoXmlTag("RcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? RecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? RecordDate { get; init; } 
    #else
    public DateFormat19Choice_? RecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_U9twQPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Registration Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDdln")]
    #endif
    [IsoXmlTag("RegnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? RegistrationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? RegistrationDeadline { get; init; } 
    #else
    public DateFormat19Choice_? RegistrationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    [IsoId("_U9twSvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Results Publication Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltsPblctnDt")]
    #endif
    [IsoXmlTag("RsltsPblctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? ResultsPublicationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? ResultsPublicationDate { get; init; } 
    #else
    public DateFormat19Choice_? ResultsPublicationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    [IsoId("_U9twVPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Deadline To Split")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DdlnToSplt")]
    #endif
    [IsoXmlTag("DdlnToSplt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? DeadlineToSplit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? DeadlineToSplit { get; init; } 
    #else
    public DateFormat19Choice_? DeadlineToSplit { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_U9twXvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DdlnForTaxBrkdwnInstr")]
    #endif
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    #else
    public DateFormat19Choice_? DeadlineForTaxBreakdownInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_U9twaPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Trading Suspended Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSspdDt")]
    #endif
    [IsoXmlTag("TradgSspdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? TradingSuspendedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? TradingSuspendedDate { get; init; } 
    #else
    public DateFormat19Choice_? TradingSuspendedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_U9twcvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Unconditional Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UcondlDt")]
    #endif
    [IsoXmlTag("UcondlDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? UnconditionalDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? UnconditionalDate { get; init; } 
    #else
    public DateFormat19Choice_? UnconditionalDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_U9twfPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Wholly Unconditional Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhlyUcondlDt")]
    #endif
    [IsoXmlTag("WhlyUcondlDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? WhollyUnconditionalDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? WhollyUnconditionalDate { get; init; } 
    #else
    public DateFormat19Choice_? WhollyUnconditionalDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_U9twhvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Ex Dividend Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExDvddDt")]
    #endif
    [IsoXmlTag("ExDvddDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? ExDividendDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? ExDividendDate { get; init; } 
    #else
    public DateFormat19Choice_? ExDividendDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    [IsoId("_U9twkPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Official Announcement Publication Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffclAnncmntPblctnDt")]
    #endif
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    #else
    public DateFormat19Choice_? OfficialAnnouncementPublicationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_U9twmvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Special Ex Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclExDt")]
    #endif
    [IsoXmlTag("SpclExDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? SpecialExDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? SpecialExDate { get; init; } 
    #else
    public DateFormat19Choice_? SpecialExDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_U9twpPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Guaranteed Participation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntedPrtcptnDt")]
    #endif
    [IsoXmlTag("GrntedPrtcptnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? GuaranteedParticipationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? GuaranteedParticipationDate { get; init; } 
    #else
    public DateFormat19Choice_? GuaranteedParticipationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.
    /// </summary>
    [IsoId("_U9twrvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Election To Counterparty Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnToCtrPtyDdln")]
    #endif
    [IsoXmlTag("ElctnToCtrPtyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? ElectionToCounterpartyDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? ElectionToCounterpartyDeadline { get; init; } 
    #else
    public DateFormat19Choice_? ElectionToCounterpartyDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_U9twuPmYEeCWoI7cIKK3pQ")]
    [DisplayName("Lapsed Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LpsdDt")]
    #endif
    [IsoXmlTag("LpsdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? LapsedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? LapsedDate { get; init; } 
    #else
    public DateFormat19Choice_? LapsedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_U9twwvmYEeCWoI7cIKK3pQ")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? PaymentDate { get; init; } 
    #else
    public DateFormat19Choice_? PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time by which the account owner must instruct directly another party, for example to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_U9tw0PmYEeCWoI7cIKK3pQ")]
    [DisplayName("Third Party Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdPtyDdln")]
    #endif
    [IsoXmlTag("ThrdPtyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? ThirdPartyDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? ThirdPartyDeadline { get; init; } 
    #else
    public DateFormat19Choice_? ThirdPartyDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_U9tw2vmYEeCWoI7cIKK3pQ")]
    [DisplayName("Early Third Party Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyThrdPtyDdln")]
    #endif
    [IsoXmlTag("EarlyThrdPtyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? EarlyThirdPartyDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? EarlyThirdPartyDeadline { get; init; } 
    #else
    public DateFormat19Choice_? EarlyThirdPartyDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    [IsoId("_U9tw5PmYEeCWoI7cIKK3pQ")]
    [DisplayName("Market Claim Tracking End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmTrckgEndDt")]
    #endif
    [IsoXmlTag("MktClmTrckgEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? MarketClaimTrackingEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? MarketClaimTrackingEndDate { get; init; } 
    #else
    public DateFormat19Choice_? MarketClaimTrackingEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last day an investor can become a lead plaintiff.
    /// </summary>
    [IsoId("_U9tw7vmYEeCWoI7cIKK3pQ")]
    [DisplayName("Lead Plaintiff Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LeadPlntffDdln")]
    #endif
    [IsoXmlTag("LeadPlntffDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? LeadPlaintiffDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? LeadPlaintiffDeadline { get; init; } 
    #else
    public DateFormat19Choice_? LeadPlaintiffDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the action was filed at the applicable court.
    /// </summary>
    [IsoId("_uOsr1fmYEeCVr71nfCO5sw")]
    [DisplayName("Filing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FilgDt")]
    #endif
    [IsoXmlTag("FilgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat16Choice_? FilingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat16Choice_? FilingDate { get; init; } 
    #else
    public DateFormat16Choice_? FilingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date for the hearing between the plaintiff and defendant, as set by the court.
    /// </summary>
    [IsoId("_z7DKlvmYEeCVr71nfCO5sw")]
    [DisplayName("Hearing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HrgDt")]
    #endif
    [IsoXmlTag("HrgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat16Choice_? HearingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat16Choice_? HearingDate { get; init; } 
    #else
    public DateFormat16Choice_? HearingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
