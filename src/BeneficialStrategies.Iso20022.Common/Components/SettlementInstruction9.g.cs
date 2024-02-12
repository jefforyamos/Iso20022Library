﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInstruction9.  ISO2002 ID# _BkIRwfWbEemtd4wHZYvFUQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_BkIRwfWbEemtd4wHZYvFUQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Settlement Instruction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInstruction9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInstruction9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInstruction9( SettlementMethod1Code reqSettlementMethod )
    {
        SettlementMethod = reqSettlementMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_B8P20fWbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementMethod1Code SettlementMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SettlementMethod1Code SettlementMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementMethod1Code SettlementMethod { get; init; } 
    #else
    public SettlementMethod1Code SettlementMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_B8P20_WbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? SettlementAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? SettlementAccount { get; init; } 
    #else
    public CashAccount38? SettlementAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_B8P21fWbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing System")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #else
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_B8P21_WbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instructing Reimbursement Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_B8P22fWbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instructing Reimbursement Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? InstructingReimbursementAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? InstructingReimbursementAgentAccount { get; init; } 
    #else
    public CashAccount38? InstructingReimbursementAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_B8P22_WbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instructed Reimbursement Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_B8P23fWbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instructed Reimbursement Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? InstructedReimbursementAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? InstructedReimbursementAgentAccount { get; init; } 
    #else
    public CashAccount38? InstructedReimbursementAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If ThirdReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// </summary>
    [IsoId("_B8P23_WbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Third Reimbursement Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? ThirdReimbursementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? ThirdReimbursementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? ThirdReimbursementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_B8P24fWbEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Third Reimbursement Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? ThirdReimbursementAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? ThirdReimbursementAgentAccount { get; init; } 
    #else
    public CashAccount38? ThirdReimbursementAgentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
