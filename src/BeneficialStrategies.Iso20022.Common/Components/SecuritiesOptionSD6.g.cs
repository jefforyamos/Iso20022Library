﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOptionSD6.  ISO2002 ID# _UvwowXh5EeOF3uSOaAf1Lg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement details.
/// </summary>
public partial record SecuritiesOptionSD6
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC(The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3Text? DTCPayMethod { get; init; } 
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3Text? DTCPayOrder { get; init; } 
    /// <summary>
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; } 
    /// <summary>
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    /// <summary>
    /// Price is based on either base or disbursed security.
    /// </summary>
    public DTCBaseDisbursed1Code? PriceBasis { get; init; } 
    /// <summary>
    /// Specifies the reason for DTC (The Depository Trust Corporation) to exit the shares.
    /// </summary>
    public SecuritiesExitReason1Code? DTCExitExplanationIndicator { get; init; } 
    /// <summary>
    /// Indicates whether a DTC (The Depository Trust Corporation) participant, using one or more payment bonds in connection with a warrant exercise, will be charged (through settlement on exercise date) the value of the upcoming interest payment on the bond(s).
    /// </summary>
    public IsoYesNoIndicator? ChargeFlag { get; init; } 
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to "no" changes are due when protect is covered.
    /// </summary>
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    /// <summary>
    /// Indicates whether the price from the offeror is estimated or final.
    /// </summary>
    public IsoYesNoIndicator? EstimatedPriceFlag { get; init; } 
    /// <summary>
    /// Time period during which instructions regarding the disposition of fractional entitlements will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    public Period3? DTCFractionalShareInstructionPeriod { get; init; } 
    /// <summary>
    /// Indicates the period during which the instructions for US Tax service will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    public Period3? DTCUSTaxInstructionPeriod { get; init; } 
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy records. The number algorhithm is as follows: Department ID (1:1), Activity Type (2:3), Cusip Country Code (5:2), Cusip (7:9), Record Date (15:8), Payable Date (22:8), Sequence Number (29:3), RDP Issue Type (31:1). 
    /// USAGE RULE: this sequence can be populated /extended to event details, option details or a movement, depending on sequence number coordinality to an event.
    /// </summary>
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    #nullable disable
}
