﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSD22.  ISO2002 ID# _Xv0Y8Q7vEeuZI5Sr_GAcuA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
public partial record CorporateActionSD22
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Indicates whether the notice received was universal or specific to securities registered in DTC's nominee name.
    /// </summary>
    public NoticeType1Code? NoticeType { get; init; } 
    /// <summary>
    /// Amount of cash set aside by the offeror. This is the maximum amount that the offeror is willing to pay out to the holders who elect to take part in the offer.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; } 
    /// <summary>
    /// Number of shares the issuer is creating as part of the event.
    /// </summary>
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; } 
    /// <summary>
    /// Total number of shares that are part of the offer, for example, subscription offer.
    /// </summary>
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; } 
    /// <summary>
    /// Number of additional days used to establish a DTC processing cut-off date. For example, DTC typically adds a cut-off off day (making it one business day prior) to the record date for issues with agents outside NYC. This allows time for DTC to deliver the securities.
    /// </summary>
    public IsoMax3Number? CutOffDays { get; init; } 
    /// <summary>
    /// Indicator that identifies the type of interface an event agent has with DTC (The Depository Trust Corporation). This defines how time sensitive the instruction and withdrawal process is. An offline (non automated) agent will have earlier deadlines which will be reflected in response deadlines but importantly withdrawal procedures for a manual agent requires hard copy sign off from the agent that has to be delivered to DTC to proceed with withdrawal.
    /// </summary>
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    /// <summary>
    /// Specifies whether the recycling of instructions for eligible positions is set to end early or late at DTC (The Depository Trust Corporation).
    /// </summary>
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the first accrual period for debt instruments is either long or short, compared to the normal accrual period of the security.
    /// </summary>
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    /// <summary>
    /// Type of oversubscription on the event.
    /// </summary>
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    /// <summary>
    /// Indicates whether the payment made by the issuer is based on a stated condition.
    /// </summary>
    public IsoYesNoIndicator? ConditionalPaymentApplicableFlag { get; init; } 
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    public IsoYesNoIndicator? SolicitationDealerFeeFlag { get; init; } 
    /// <summary>
    /// Indicates whether positions held in custody program are eligible for instruction processing at DTC (The Depository Trust Corporation).
    /// </summary>
    public IsoYesNoIndicator? DTCCustodyEligibleFlag { get; init; } 
    /// <summary>
    /// Indicates whether the event is eligible for the custody reorganisation service at DTC (The Depository Trust Corporation).
    /// </summary>
    public IsoYesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; } 
    /// <summary>
    /// Indicates whether the event is eligible for the reorganisation deposit service at DTC (The Depository Trust Corporation).
    /// </summary>
    public IsoYesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; } 
    /// <summary>
    /// Indicates whether shares outside of DTC need to be delivered to the agent in order to receive entitlement.
    /// </summary>
    public IsoYesNoIndicator? SurrenderSharesToAgentFlag { get; init; } 
    /// <summary>
    /// Indicates that the holder has the privilege to buy additional rights. Upon exercising this privilege, the holder may subscribe to one additional share of the new security in lieu of fractional shares to which the holder might otherwise be entitled.
    /// </summary>
    public IsoYesNoIndicator? StepUpPrivilegeFlag { get; init; } 
    /// <summary>
    /// Indicates whether holders of rights will be afforded the opportunity to subscribe to purchase extra shares that are not picked up by the remaining holders.
    /// </summary>
    public IsoYesNoIndicator? RightsOversubscriptionFlag { get; init; } 
    /// <summary>
    /// Indicates whether the shareholder will be able to round up its subscription in the event its rights are less than the requirement.
    /// </summary>
    public IsoYesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; } 
    /// <summary>
    /// Indicates whether rights can be transferred.
    /// </summary>
    public IsoYesNoIndicator? RightsTransferableFlag { get; init; } 
    /// <summary>
    /// Indicates whether rights are available to stockholders as a remedy when they object to the terms of proposed corporate actions. For example, actions can include but are not limited to a merger or a sale of assets. 
    /// This flag will output to Y/N ("true"/"false" or "1"/"0") or whereas the Option Features Code (DISS) in the standard only used when Yes. 
    /// </summary>
    public IsoYesNoIndicator? DissenterRightsApplicableFlag { get; init; } 
    /// <summary>
    /// Indicates whether the certificate of deposit early redemption event is exempt from the presentation of the required legal documentation. When presentation is exempt, the instructing client agrees to maintain such documentation for at least 30 months following payment of the request.
    /// </summary>
    public IsoYesNoIndicator? NonExemptAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether instructions are temporarily blocked for the event.
    /// </summary>
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; init; } 
    /// <summary>
    /// Details of certificates that have been called for redemption.
    /// </summary>
    public CorporateActionSD15[] CertificateDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Country of issue used to determine whether the electable option requires tax exempt or wire information when sending EDS elections via the CAIN message type.
    /// </summary>
    public CountryCode? EDSMessagingCountryCode { get; init; } 
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be "on" the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    #nullable disable
}
