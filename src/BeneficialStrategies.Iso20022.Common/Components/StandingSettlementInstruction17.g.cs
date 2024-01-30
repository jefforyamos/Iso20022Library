﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StandingSettlementInstruction17.  ISO2002 ID# _6sllzffVEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the standing settlement instruction to be applied.
/// </summary>
public partial record StandingSettlementInstruction17
{
    #nullable enable
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    public required ISettlementStandingInstructionDatabase5Choice SettlementStandingInstructionDatabase { get; init; } 
    /// <summary>
    /// Identification of the buyer or seller in a standing settlement instruction enabling to derive the Standing Settlement Instruction.
    /// </summary>
    public required ICounterparty14Choice Counterparty { get; init; } 
    /// <summary>
    /// Vendor of the settlement standing instruction database that is to be consulted.
    /// </summary>
    public PartyIdentification157? Vendor { get; init; } 
    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    public SettlementParties81? OtherDeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    public SettlementParties81? OtherReceivingSettlementParties { get; init; } 
    
    #nullable disable
}
