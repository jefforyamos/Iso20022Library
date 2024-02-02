﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cheque13.  ISO2002 ID# _2YR7EQF9EeuDW9bNZAE8VA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a cheque instruction, such as cheque type or cheque number.
/// </summary>
[DataContract]
[XmlType]
public partial record Cheque13
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction. 
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [DataMember]
    public IsoMax35Text? InstructionIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [DataMember]
    public required IsoMax35Text ChequeNumber { get; init; } 
    /// <summary>
    /// Date when the cheque has been issued by the payer.
    /// </summary>
    [DataMember]
    public required IsoISODate IssueDate { get; init; } 
    /// <summary>
    /// Date after which a cheque is no longer valid. The validity period of a cheque is calculated from the issue date on the face of the cheque.  The period may be indicated on the face of the cheque itself such as "Valid for 90 days” or may be determined in accordance with domestic banking practice. 
    /// Not all countries will have a validity period. 
    /// </summary>
    [DataMember]
    public IsoISODate? StaleDate { get; init; } 
    /// <summary>
    /// Specifies the amount of the cheque to be paid to the payee.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Date and time at which the cheque amount becomes available on the payee account.
    /// </summary>
    [DataMember]
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    /// <summary>
    /// Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [DataMember]
    public PartyIdentification135? Payer { get; init; } 
    /// <summary>
    /// Specifies the cash account of the payer.
    /// </summary>
    [DataMember]
    public CashAccount40? PayerAccount { get; init; } 
    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification6? DrawerAgent { get; init; } 
    /// <summary>
    /// Specifies the cash account of the drawer agent.
    /// </summary>
    [DataMember]
    public CashAccount40? DrawerAgentAccount { get; init; } 
    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// </summary>
    [DataMember]
    public required PartyIdentification135 Payee { get; init; } 
    /// <summary>
    /// Specifies the cash account of the payee.
    /// </summary>
    [DataMember]
    public CashAccount40? PayeeAccount { get; init; } 
    /// <summary>
    /// Further information related to the processing of the cheque instruction that may need to be acted upon by the agent processing the cheque.
    /// </summary>
    [DataMember]
    public ValueList<InstructionForChequeAgent1> InstructionForChequeAgent { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
