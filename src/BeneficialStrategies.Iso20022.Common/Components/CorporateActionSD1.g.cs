﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSD1.  ISO2002 ID# _1hhk0jL3EeKU9IrkkToqcw_1235439158.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [DataMember]
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Indicates whether the notice received was universal or specific to securities registered in DTC's nominee name.
    /// </summary>
    [DataMember]
    public NoticeType1Code? NoticeType { get; init; } 
    /// <summary>
    /// Amount of cash set aside by the offeror. This is the maximum amount that the offeror is willing to pay out to the holders who elect to take part in the offer.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? EventCashValue { get; init; } 
    /// <summary>
    /// Number of shares the issuer is creating as part of the event.
    /// </summary>
    [DataMember]
    public IsoDecimalNumber? NumberOfSharesToBeIssued { get; init; } 
    /// <summary>
    /// Total number of shares that are part of the offer for example subscription offer.
    /// </summary>
    [DataMember]
    public IsoDecimalNumber? TotalNumberOfSharesOffered { get; init; } 
    /// <summary>
    /// Number of additional days used to establish a DTC processing cut-off date. For example, DTC typically adds a cut-off off day (making it one business day prior) to the record date for issues with agents outside NYC. This allows time for DTC to deliver the securities.
    /// </summary>
    [DataMember]
    public IsoMax3Number? CutOffDays { get; init; } 
    /// <summary>
    /// Indicator that identifies the type of interface an event agent has with DTC (The Depository Trust Corporation). It defines how time sensitive instruction and withdrawal process is. Offline (non automated) agent will have earlier deadlines which will be reflected in response deadlines but importantly withdrawal procedures for manual agent require hard copy sign off from the agent that has to be delivered to DTC to proceed with withdrawal.
    /// </summary>
    [DataMember]
    public DTCAutoOfferProgram1Code? DTCAutomatedOfferProgram { get; init; } 
    /// <summary>
    /// Indicates whether the recycling of instructions for eligible positions is set to end early or late at DTC (The Depository Trust Corporation).
    /// </summary>
    [DataMember]
    public CutOff1Code? DTCRecycleCutOffIndicator { get; init; } 
    /// <summary>
    /// Denotes whether the first accrual period for debt instruments is either long or short, compared to the normal accrual period of the security.
    /// </summary>
    [DataMember]
    public AccrualPeriodType1Code? LongShortPaymentIndicator { get; init; } 
    /// <summary>
    /// Type of oversubscription on the event.
    /// </summary>
    [DataMember]
    public OversubscriptionType1Code? OversubscriptionType { get; init; } 
    /// <summary>
    /// Indicates whether the payment made by the issuer is based on a stated condition.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ConditionalPaymentApplicableFlag { get; init; } 
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? SolicitationDealerFeeFlag { get; init; } 
    /// <summary>
    /// Indicates whether positions held in Custody program are eligible for instruction processing at DTC (The Depository Trust Corporation).
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? DTCCustodyEligibleFlag { get; init; } 
    /// <summary>
    /// Indicates whether the event is eligible for Custody Reorganisation service at DTC (The Depository Trust Corporation).
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? DTCReorganisationCustodyEligibleFlag { get; init; } 
    /// <summary>
    /// Indicates whether the event is eligible for Reorganisation Deposit Service at DTC (The Depository Trust Corporation).
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? DTCReorganisationDepositEligibleFlag { get; init; } 
    /// <summary>
    /// Indicates whether shares outside of DTC need to be delivered to the agent in order to receive entitlement.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? SurrenderSharesToAgentFlag { get; init; } 
    /// <summary>
    /// Indicates that the holder has the privilege to buy additional rights. Upon exercising this privilege, the holder may subscribe to one additional share of the new security in lieu of fractional shares to which the holder might otherwise be entitled.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? StepUpPrivilegeFlag { get; init; } 
    /// <summary>
    /// Indicates whether holders of rights will be afforded the opportunity to subscribe to purchase extra shares that are not picked up by the remaining holders.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? RightsOversubscriptionFlag { get; init; } 
    /// <summary>
    /// Indicates whether the shareholder will be able to round up his/her subscription in the event his/her rights are less than the requirement.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? RightsRoundUpPrivilegeFlag { get; init; } 
    /// <summary>
    /// Indicates whether rights can be transferred.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? RightsTransferableFlag { get; init; } 
    /// <summary>
    /// Provides details of certificates that have been called for redemption.
    /// </summary>
    [DataMember]
    public ValueList<CorporateActionSD5> CertificateDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
