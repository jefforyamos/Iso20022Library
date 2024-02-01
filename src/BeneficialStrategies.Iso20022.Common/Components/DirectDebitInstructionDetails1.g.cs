﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DirectDebitInstructionDetails1.  ISO2002 ID# _W-O3YQ2mEeSNWNtJlXOAhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructions, initiated by the creditor, to debit a debtor's account in favour of the creditor.
/// </summary>
public partial record DirectDebitInstructionDetails1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the mandate for a direct debit instruction.
    /// </summary>
    public required IsoMax35Text MandateIdentification { get; init; } 
    /// <summary>
    /// Indicates whether the instruction is an automated direct debit instruction.
    /// Usage: Default value for AutomatedDirectDebitInstructionIndicator is false.
    /// </summary>
    public IsoYesNoIndicator? AutomatedDirectDebitInstructionIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the direct debit instruction is transferable.
    /// Usage: Default value for DirectDebitTransferableIndicator is false.
    /// </summary>
    public IsoYesNoIndicator? DirectDebitTransferableIndicator { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public required PartyIdentification125 Creditor { get; init; } 
    /// <summary>
    /// Amount of the last debit made for the direct debit mandate.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? LastCollectionCurrencyAmount { get; init; } 
    /// <summary>
    /// Date on which the last debit for the direct debit mandate may be made.
    /// Usage: Not included if all limits to the validity of the direct debit mandate have already been specified or if there are no time limits on the validity of the direct debit.
    /// </summary>
    public IsoISODate? LastCollectionDate { get; init; } 
    /// <summary>
    /// Provides further information about the status of a requested transaction schedule transfer.
    /// </summary>
    public TransferInstruction1[] OtherDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
