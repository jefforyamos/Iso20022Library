﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditTransferDetails.  ISO2002 ID# _weKLGzbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument20Choice
{
    /// <summary>
    /// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_weKLGzbsEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Credit Transfer Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CreditTransferDetails : PaymentInstrument20Choice_
    #else
    public partial class CreditTransferDetails : PaymentInstrument20Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CreditTransferDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CreditTransferDetails( FinancialInstitutionIdentification10 reqCreditorAgent,AccountIdentificationAndName5 reqCreditorAccount )
        {
            CreditorAgent = reqCreditorAgent;
            CreditorAccount = reqCreditorAccount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
        /// </summary>
        [IsoId("_yCJGVTbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reference")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Reference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Reference { get; init; } 
        #else
        public System.String? Reference { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
        /// </summary>
        [IsoId("_yCJGVzbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Debtor")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification113? Debtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification113? Debtor { get; init; } 
        #else
        public PartyIdentification113? Debtor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_yCJGWTbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Debtor Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName5? DebtorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName5? DebtorAccount { get; init; } 
        #else
        public AccountIdentificationAndName5? DebtorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the debtor.
        /// </summary>
        [IsoId("_yCJGWzbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Debtor Agent")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification10? DebtorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification10? DebtorAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification10? DebtorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the account of the debtor's agent.
        /// </summary>
        [IsoId("_yCJGXTbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Debtor Agent Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName5? DebtorAgentAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName5? DebtorAgentAccount { get; init; } 
        #else
        public AccountIdentificationAndName5? DebtorAgentAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor's agent and the creditor's agent.
        /// </summary>
        [IsoId("_yCJGXzbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Intermediary Agent")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification10? IntermediaryAgent1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification10? IntermediaryAgent1 { get; init; } 
        #else
        public FinancialInstitutionIdentification10? IntermediaryAgent1 { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_yCJGYTbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Intermediary Agent 1 Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName5? IntermediaryAgent1Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName5? IntermediaryAgent1Account { get; init; } 
        #else
        public AccountIdentificationAndName5? IntermediaryAgent1Account { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor's agent and the creditor's agent.
        /// </summary>
        [IsoId("_yCJGYzbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Intermediary Agent")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification10? IntermediaryAgent2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification10? IntermediaryAgent2 { get; init; } 
        #else
        public FinancialInstitutionIdentification10? IntermediaryAgent2 { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_yCJGZTbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Intermediary Agent 2 Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName5? IntermediaryAgent2Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName5? IntermediaryAgent2Account { get; init; } 
        #else
        public AccountIdentificationAndName5? IntermediaryAgent2Account { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_yCJGZzbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Creditor Agent")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstitutionIdentification10 CreditorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public FinancialInstitutionIdentification10 CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification10 CreditorAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification10 CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
        /// </summary>
        [IsoId("_yCJGaTbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Creditor Agent Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName5? CreditorAgentAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName5? CreditorAgentAccount { get; init; } 
        #else
        public AccountIdentificationAndName5? CreditorAgentAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
        /// </summary>
        [IsoId("_yCJGazbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Creditor")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification113? Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification113? Creditor { get; init; } 
        #else
        public PartyIdentification113? Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_yCJGbTbsEead9bDRE_1DAQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Creditor Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AccountIdentificationAndName5 CreditorAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AccountIdentificationAndName5 CreditorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName5 CreditorAccount { get; init; } 
        #else
        public AccountIdentificationAndName5 CreditorAccount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
