﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionTransactionSD6.  ISO2002 ID# _rV3zQQCEEeqouY-yI_q3qQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement option details.
/// </summary>
public partial record OptionTransactionSD6
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC Instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    public required IsoMax15Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
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
    /// Oversubscribed quantity of the instruction.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// For prorated events, portion of the instructed units that was accepted by the Issuer / Agent.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? AcceptedQuantity { get; init; } 
    /// <summary>
    /// For prorated events, the portion of the instructed quantity that was not accepted by the Issuer / Agent.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? UnacceptedQuantity { get; init; } 
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? EntitledQuantity { get; init; } 
    /// <summary>
    /// Entitled units for the oversubscription.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? EntitledOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// Amount paid to the issuer / agent for subscription cost.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; } 
    /// <summary>
    /// Amount paid to the issuer / agent for the oversubscription cost.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    /// <summary>
    /// Quantity entered by the agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? AgentEnteredQuantity { get; init; } 
    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    public IsoMax210Text? InstructionComments { get; init; } 
    /// <summary>
    /// Amount of money debited or credited to adjust for the difference between the estimated and the final subscription rate for Rights Exercise events.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; init; } 
    /// <summary>
    /// Amount of money refunded from the original subscription cost for a Rights Exercise event.  This occurs when the event is prorated and the subscription cost relating to the unaffected (unaccepted) balance is returned to the holder.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; } 
    
    #nullable disable
}
