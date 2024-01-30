﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOptionSD2.  ISO2002 ID# _1ls6NDL3EeKU9IrkkToqcw_-899891654.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
public partial record CashOptionSD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    public ReinvestmentIncomeClassification1Code? ReinvestmentIncomeClassification { get; init; } 
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3Text? DTCPayMethod { get; init; } 
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    public IsoMax3Text? DTCPayOrder { get; init; } 
    /// <summary>
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    /// <summary>
    /// Identifies the income events which are subject to withholding tax if paid to a non-U.S. resident alien (NRA).
    /// </summary>
    public IsoYesNoIndicator? NRATaxReportableFlag { get; init; } 
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to "no" changes are due when protect is covered.
    /// </summary>
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    /// <summary>
    /// Corresponding cash rate paid by CSD.
    /// </summary>
    public IPriceFormatSD1Choice? CSDCashRate { get; init; } 
    /// <summary>
    /// Rate at which a fee will be charged to a DTC (The Depository Trust Corporation) participant.
    /// </summary>
    public IPriceFormatSD1Choice? DTCFeeRate { get; init; } 
    /// <summary>
    /// Indicates the period during which the instructions for DTC (The Depository Trust Corporation) US Tax service will be accepted.
    /// </summary>
    public Period3? DTCUSTaxInstructionPeriod { get; init; } 
    
    #nullable disable
}
