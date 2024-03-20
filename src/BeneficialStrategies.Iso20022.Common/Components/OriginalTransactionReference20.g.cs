﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalTransactionReference20.  ISO2002 ID# _mtOwDx72EeSxevWRRWxNAg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Key elements used to refer the original transaction.
/// </summary>
[IsoId("_mtOwDx72EeSxevWRRWxNAg")]
[DisplayName("Original Transaction Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalTransactionReference20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_m-xy8R72EeSxevWRRWxNAg")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_m-xy8x72EeSxevWRRWxNAg")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountType4Choice_? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountType4Choice_? Amount { get; init; } 
    #else
    public AmountType4Choice_? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_m-xy9R72EeSxevWRRWxNAg")]
    [DisplayName("Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDt")]
    #endif
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("_m-xy9x72EeSxevWRRWxNAg")]
    [DisplayName("Requested Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdColltnDt")]
    #endif
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedCollectionDate { get; init; } 
    #else
    public System.DateOnly? RequestedCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor&apos;s account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    [IsoId("_m-xy-R72EeSxevWRRWxNAg")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedExecutionDate { get; init; } 
    #else
    public System.DateOnly? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_m-xy-x72EeSxevWRRWxNAg")]
    [DisplayName("Creditor Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrSchmeId")]
    #endif
    [IsoXmlTag("CdtrSchmeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification43? CreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details on how the settlement of the original transaction(s) between the instructing agent and the instructed agent was completed.
    /// </summary>
    [IsoId("_m-xy_R72EeSxevWRRWxNAg")]
    [DisplayName("Settlement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInf")]
    #endif
    [IsoXmlTag("SttlmInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementInstruction1? SettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInstruction1? SettlementInformation { get; init; } 
    #else
    public SettlementInstruction1? SettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_m-xy_x72EeSxevWRRWxNAg")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation25? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_m-xzAR72EeSxevWRRWxNAg")]
    [DisplayName("Payment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtd")]
    #endif
    [IsoXmlTag("PmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentMethod4Code? PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMethod4Code? PaymentMethod { get; init; } 
    #else
    public PaymentMethod4Code? PaymentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_m-xzAx72EeSxevWRRWxNAg")]
    [DisplayName("Mandate Related Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtRltdInf")]
    #endif
    [IsoXmlTag("MndtRltdInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateRelatedInformation10? MandateRelatedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateRelatedInformation10? MandateRelatedInformation { get; init; } 
    #else
    public MandateRelatedInformation10? MandateRelatedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_m-xzBR72EeSxevWRRWxNAg")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation10? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation10? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation10? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_m-xzBx72EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification43? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_m-xzCR72EeSxevWRRWxNAg")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Debtor { get; init; } 
    #else
    public PartyIdentification43? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_m-xzCx72EeSxevWRRWxNAg")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? DebtorAccount { get; init; } 
    #else
    public CashAccount24? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_m-xzDR72EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_m-xzDx72EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgtAcct")]
    #endif
    [IsoXmlTag("DbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? DebtorAgentAccount { get; init; } 
    #else
    public CashAccount24? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_m-xzER72EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_m-xzEx72EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgtAcct")]
    #endif
    [IsoXmlTag("CdtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? CreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? CreditorAgentAccount { get; init; } 
    #else
    public CashAccount24? CreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_m-xzFR72EeSxevWRRWxNAg")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Creditor { get; init; } 
    #else
    public PartyIdentification43? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_m-xzFx72EeSxevWRRWxNAg")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? CreditorAccount { get; init; } 
    #else
    public CashAccount24? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_m-xzGR72EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification43? UltimateCreditor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
