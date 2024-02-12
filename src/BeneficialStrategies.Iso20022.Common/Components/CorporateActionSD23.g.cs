﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSD23.  ISO2002 ID# _Sh5fEVB6Ee2KGNXAcFL5RA.
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
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_Sh5fEVB6Ee2KGNXAcFL5RA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action SD")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionSD23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_S7rRA1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place And Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the notice received was universal or specific to securities registered in DTC's nominee name.
    /// </summary>
    [IsoId("_S7rRBVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notice Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NoticeType1Code? NoticeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NoticeType1Code? NoticeType { get; init; } 
    #else
    public NoticeType1Code? NoticeType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash set aside by the offeror. This is the maximum amount that the offeror is willing to pay out to the holders who elect to take part in the offer.
    /// </summary>
    [IsoId("_S7rRDVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Event Cash Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EventCashValue { get; init; } 
    #else
    public System.Decimal? EventCashValue { get; set; } 
    #endif
    
    /// <summary>
    /// Number of shares the issuer is creating as part of the event.
    /// </summary>
    [IsoId("_S7rRG1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Shares To Be Issued")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfSharesToBeIssued { get; init; } 
    #else
    public System.UInt64? NumberOfSharesToBeIssued { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of shares that are part of the offer, for example, subscription offer.
    /// </summary>
    [IsoId("_S7rRI1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Number Of Shares Offered")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfSharesOffered { get; init; } 
    #else
    public System.UInt64? TotalNumberOfSharesOffered { get; set; } 
    #endif
    
    /// <summary>
    /// Number of additional days used to establish a DTC processing cut-off date. For example, DTC typically adds a cut-off off day (making it one business day prior) to the record date for issues with agents outside NYC. This allows time for DTC to deliver the securities.
    /// </summary>
    [IsoId("_S7rRK1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cut Off Days")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? CutOffDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CutOffDays { get; init; } 
    #else
    public System.UInt64? CutOffDays { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator that identifies the type of interface an event agent has with DTC (The Depository Trust Corporation). This defines how time sensitive the instruction and withdrawal process is. An offline (non automated) agent will have earlier deadlines which will be reflected in response deadlines but importantly withdrawal procedures for a manual agent requires hard copy sign off from the agent that has to be delivered to DTC to proceed with withdrawal.
    /// </summary>
    [IsoId("_S7rRM1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("DTC Automated Offer Program")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    #else
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the recycling of instructions for eligible positions is set to end early or late at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_S7rRO1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("DTC Recycle Cut Off Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    #else
    public CutOff1Code? DTCRecycleCutOffIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the first accrual period for debt instruments is either long or short, compared to the normal accrual period of the security.
    /// </summary>
    [IsoId("_S7rRQ1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Long Short Payment Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    #else
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of oversubscription on the event.
    /// </summary>
    [IsoId("_S7rRS1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Oversubscription Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    #else
    public OversubscriptionType1Code? OversubscriptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment made by the issuer is based on a stated condition.
    /// </summary>
    [IsoId("_S7rRU1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Conditional Payment Applicable Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConditionalPaymentApplicableFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConditionalPaymentApplicableFlag { get; init; } 
    #else
    public System.String? ConditionalPaymentApplicableFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    [IsoId("_S7rRW1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Solicitation Dealer Fee Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SolicitationDealerFeeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SolicitationDealerFeeFlag { get; init; } 
    #else
    public System.String? SolicitationDealerFeeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether positions held in custody program are eligible for instruction processing at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_S7rRY1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("DTC Custody Eligible Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCCustodyEligibleFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCCustodyEligibleFlag { get; init; } 
    #else
    public System.String? DTCCustodyEligibleFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event is eligible for the custody reorganisation service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_S7rRa1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("DTC Reorganisation Custody Eligible Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCReorganisationCustodyEligibleFlag { get; init; } 
    #else
    public System.String? DTCReorganisationCustodyEligibleFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event is eligible for the reorganisation deposit service at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_S7rRc1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("DTC Reorganisation Deposit Eligible Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCReorganisationDepositEligibleFlag { get; init; } 
    #else
    public System.String? DTCReorganisationDepositEligibleFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether shares outside of DTC need to be delivered to the agent in order to receive entitlement.
    /// </summary>
    [IsoId("_S7rRe1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Surrender Shares To Agent Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SurrenderSharesToAgentFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SurrenderSharesToAgentFlag { get; init; } 
    #else
    public System.String? SurrenderSharesToAgentFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the holder has the privilege to buy additional rights. Upon exercising this privilege, the holder may subscribe to one additional share of the new security in lieu of fractional shares to which the holder might otherwise be entitled.
    /// </summary>
    [IsoId("_S71CAVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Step Up Privilege Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StepUpPrivilegeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StepUpPrivilegeFlag { get; init; } 
    #else
    public System.String? StepUpPrivilegeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether holders of rights will be afforded the opportunity to subscribe to purchase extra shares that are not picked up by the remaining holders.
    /// </summary>
    [IsoId("_S71CCVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rights Oversubscription Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RightsOversubscriptionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RightsOversubscriptionFlag { get; init; } 
    #else
    public System.String? RightsOversubscriptionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the shareholder will be able to round up its subscription in the event its rights are less than the requirement.
    /// </summary>
    [IsoId("_S71CEVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rights Round Up Privilege Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RightsRoundUpPrivilegeFlag { get; init; } 
    #else
    public System.String? RightsRoundUpPrivilegeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether rights can be transferred.
    /// </summary>
    [IsoId("_S71CGVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rights Transferable Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RightsTransferableFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RightsTransferableFlag { get; init; } 
    #else
    public System.String? RightsTransferableFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether rights are available to stockholders as a remedy when they object to the terms of proposed corporate actions. For example, actions can include but are not limited to a merger or a sale of assets. 
    /// This flag will output to Y/N ("true"/"false" or "1"/"0") or whereas the Option Features Code (DISS) in the standard only used when Yes. 
    /// </summary>
    [IsoId("_S71CIVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dissenter Rights Applicable Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DissenterRightsApplicableFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DissenterRightsApplicableFlag { get; init; } 
    #else
    public System.String? DissenterRightsApplicableFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the certificate of deposit early redemption event is exempt from the presentation of the required legal documentation. When presentation is exempt, the instructing client agrees to maintain such documentation for at least 30 months following payment of the request.
    /// </summary>
    [IsoId("_S71CI1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Non Exempt Allowed Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NonExemptAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonExemptAllowedIndicator { get; init; } 
    #else
    public System.String? NonExemptAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether instructions are temporarily blocked for the event.
    /// </summary>
    [IsoId("_S71CJVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("DTC Instruction Lockout Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; init; } 
    #else
    public InstructionLockoutType1Code? DTCInstructionLockoutIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Details of certificates that have been called for redemption.
    /// </summary>
    [IsoId("_S71CJ1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certificate Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD15? CertificateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD15? CertificateDetails { get; init; } 
    #else
    public CorporateActionSD15? CertificateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Country of issue used to determine whether the electable option requires tax exempt or wire information when sending EDS elections via the CAIN message type.
    /// </summary>
    [IsoId("_S71CL1B6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("EDS Messaging Country Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? EDSMessagingCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? EDSMessagingCountryCode { get; init; } 
    #else
    public string? EDSMessagingCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be "on" the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_S71CMVB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("RDP Reference Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RDPReferenceNumber { get; init; } 
    #else
    public System.String? RDPReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies events that offer instruction processing specific to foreign tax elections.
    /// </summary>
    [IsoId("_hqLs0FB6Ee2KGNXAcFL5RA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("DTC Foreign Tax Election Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCForeignTaxElectionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCForeignTaxElectionFlag { get; init; } 
    #else
    public System.String? DTCForeignTaxElectionFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
