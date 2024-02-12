﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransfer9.  ISO2002 ID# _y0S3MU3zEeiQHa-q1Uephw.
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
/// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
/// </summary>
[IsoId("_y0S3MU3zEeiQHa-q1Uephw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Credit Transfer")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditTransfer9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditTransfer9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditTransfer9( FinancialInstitutionIdentification16 reqCreditorAgent,AccountIdentificationAndName6 reqCreditorAccount )
    {
        CreditorAgent = reqCreditorAgent;
        CreditorAccount = reqCreditorAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    [IsoId("_zEgdd03zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification132? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification132? Debtor { get; init; } 
    #else
    public PartyIdentification132? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_zEgdeU3zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentificationAndName6? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName6? DebtorAccount { get; init; } 
    #else
    public AccountIdentificationAndName6? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing the account for the debtor.
    /// </summary>
    [IsoId("_zEgde03zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification16? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification16? DebtorAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification16? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the account of the debtor's agent.
    /// </summary>
    [IsoId("_zEgdfU3zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentificationAndName6? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName6? DebtorAgentAccount { get; init; } 
    #else
    public AccountIdentificationAndName6? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("_zEgdf03zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Intermediary Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification16? IntermediaryAgent1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification16? IntermediaryAgent1 { get; init; } 
    #else
    public FinancialInstitutionIdentification16? IntermediaryAgent1 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_zEgdgU3zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Intermediary Agent 1 Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentificationAndName6? IntermediaryAgent1Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName6? IntermediaryAgent1Account { get; init; } 
    #else
    public AccountIdentificationAndName6? IntermediaryAgent1Account { get; set; } 
    #endif
    
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("_zEgdg03zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Intermediary Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification16? IntermediaryAgent2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification16? IntermediaryAgent2 { get; init; } 
    #else
    public FinancialInstitutionIdentification16? IntermediaryAgent2 { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_zEgdhU3zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Intermediary Agent 2 Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentificationAndName6? IntermediaryAgent2Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName6? IntermediaryAgent2Account { get; init; } 
    #else
    public AccountIdentificationAndName6? IntermediaryAgent2Account { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing the account for the creditor.
    /// </summary>
    [IsoId("_zEgdh03zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification16 CreditorAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstitutionIdentification16 CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification16 CreditorAgent { get; init; } 
    #else
    public FinancialInstitutionIdentification16 CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_zEgdiU3zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentificationAndName6? CreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName6? CreditorAgentAccount { get; init; } 
    #else
    public AccountIdentificationAndName6? CreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_zEgdi03zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification132? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification132? Creditor { get; init; } 
    #else
    public PartyIdentification132? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_zEgdjU3zEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentificationAndName6 CreditorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AccountIdentificationAndName6 CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName6 CreditorAccount { get; init; } 
    #else
    public AccountIdentificationAndName6 CreditorAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
