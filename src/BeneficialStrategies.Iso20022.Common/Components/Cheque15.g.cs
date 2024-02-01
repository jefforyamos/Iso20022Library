﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cheque15.  ISO2002 ID# _uBZX7Sm6EeutWNGMV2XKIQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a cheque instruction, such as cheque type or cheque number.
/// </summary>
public partial record Cheque15
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction. 
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    public IsoMax35Text? InstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    public required IsoMax35Text ChequeNumber { get; init; } 
    /// <summary>
    /// Date when the cheque has been issued by the payer.
    /// </summary>
    public required IsoISODate IssueDate { get; init; } 
    /// <summary>
    /// Date after which a cheque is no longer valid.
    /// Usage:
    /// The validity period of a cheque is calculated from the issue date on the face of the cheque.
    /// The period may be indicated on the face of the cheque itself such as "Valid for 90 days” or may be determined in accordance with domestic banking practice. 
    /// Not all countries will have a validity period. 
    /// </summary>
    public IsoISODate? StaleDate { get; init; } 
    /// <summary>
    /// Specifies the amount of the cheque to be paid to the payee.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Date and time at which the cheque amount becomes available on the payee account.
    /// </summary>
    public DateAndDateTime2Choice_? EffectiveDate { get; init; } 
    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? DrawerAgent { get; init; } 
    /// <summary>
    /// Specifies the cash account of the drawer agent.
    /// </summary>
    public CashAccount40? DrawerAgentAccount { get; init; } 
    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// </summary>
    public PartyIdentification135? Payee { get; init; } 
    /// <summary>
    /// Specifies the cash account of the payee.
    /// </summary>
    public CashAccount40? PayeeAccount { get; init; } 
    /// <summary>
    /// Specifies the reason for stopping the payment of the cheque or a request for reimbursement authorisation.
    /// </summary>
    public ChequeCancellationReason1? ChequeCancellationOrStopReason { get; init; } 
    
    #nullable disable
}
