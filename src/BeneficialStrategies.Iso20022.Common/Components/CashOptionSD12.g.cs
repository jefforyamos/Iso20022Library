﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOptionSD12.  ISO2002 ID# _KNIpERRrEeuMTf7NxFqaqA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
[DataContract]
[XmlType]
public partial record CashOptionSD12
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [DataMember]
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [DataMember]
    public required DTCCPayoutType5Code PayoutType { get; init; } 
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [DataMember]
    public IsoMax3Text? DTCPayMethod { get; init; } 
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [DataMember]
    public IsoMax3Text? DTCPayOrder { get; init; } 
    /// <summary>
    /// Indicates how the entitlements were calculated for optional dividends.
    /// </summary>
    [DataMember]
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    /// <summary>
    /// Indicates whether the rate is approximate.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    /// <summary>
    /// Indicates whether the income event is subject to withholding tax if paid to a non-U.S. resident alien (NRA).
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? NRATaxReportableFlag { get; init; } 
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to "no" changes are due when protect is covered.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    /// <summary>
    /// Cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [DataMember]
    public PriceFormatSD3Choice_? DeclaredCashRate { get; init; } 
    /// <summary>
    /// Gross cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [DataMember]
    public PriceFormatSD3Choice_? DeclaredGrossRate { get; init; } 
    /// <summary>
    /// Net cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [DataMember]
    public PriceFormatSD3Choice_? DeclaredNetRate { get; init; } 
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [DataMember]
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; } 
    /// <summary>
    /// Indicates the period during which the instructions for DTC (The Depository Trust Corporation) US Tax service will be accepted.
    /// </summary>
    [DataMember]
    public Period13? DTCUSTaxInstructionPeriod { get; init; } 
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: an event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number element in event details, and also on the cash option. The activity type 54 will be "on" the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganisation, distribution, or redemption).
    /// </summary>
    [DataMember]
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    /// <summary>
    /// Specifies the type of income.
    /// Usage: When a cash movement has both US and Canadian tax implications, the US (IRSX) issuer code will be in the base message and the Canadian (CDSL) issuer code will be in the extension.
    /// </summary>
    [DataMember]
    public GenericIdentification47? IncomeType { get; init; } 
    
    #nullable disable
}
