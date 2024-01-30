﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionTransactionDetailsSD1.  ISO2002 ID# _mi1bIJElEeajS_7NioJdVA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement option details.
/// </summary>
public partial record OptionTransactionDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Unique number assigned by the Depository. Transaction identification will be either the DTC Instruction Reference Number for reorganisation instructions (VOI) or the DAM Reference Number for custody / reorganisation deposits.
    /// </summary>
    public required IsoMax15Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Number which further identifies DTC intsruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    public required IFinancialInstrumentQuantity15Choice TransactionIdentificationQuantity { get; init; } 
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? EntitledQuantity { get; init; } 
    /// <summary>
    /// Quantity entered by the Agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? AgentEnteredQuantity { get; init; } 
    /// <summary>
    /// Instructed quantity less the quantity entered by Agent on PUT (Mortgage Backed) instructions. Remaining unpaid quantity.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? AgentRemainingQuantity { get; init; } 
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    public IsoMax15Text? CustomerReferenceIdentification { get; init; } 
    
    #nullable disable
}
