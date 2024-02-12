﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalTransactionReference13.  ISO2002 ID# _P1c64Np-Ed-ak6NoX_4Aeg_440658084.
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
/// Set of key elements used to refer the original transaction.
/// </summary>
[IsoId("_P1c64Np-Ed-ak6NoX_4Aeg_440658084")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Original Transaction Reference")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalTransactionReference13
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
    [IsoId("_P1c64dp-Ed-ak6NoX_4Aeg_440658115")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interbank Settlement Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterbankSettlementAmount { get; init; } 
    #else
    public System.Decimal? InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_P1c64tp-Ed-ak6NoX_4Aeg_440659472")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountType3Choice_? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountType3Choice_? Amount { get; init; } 
    #else
    public AmountType3Choice_? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_P1c649p-Ed-ak6NoX_4Aeg_440658145")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interbank Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
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
    [IsoId("_P1c65Np-Ed-ak6NoX_4Aeg_440658207")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Requested Collection Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedCollectionDate { get; init; } 
    #else
    public System.DateOnly? RequestedCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    [IsoId("_P1c65dp-Ed-ak6NoX_4Aeg_440658485")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Requested Execution Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
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
    [IsoId("_P1c65tp-Ed-ak6NoX_4Aeg_440659071")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Scheme Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? CreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? CreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification32? CreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details on how the settlement of the original transaction(s) between the instructing agent and the instructed agent was completed.
    /// </summary>
    [IsoId("_P1c659p-Ed-ak6NoX_4Aeg_440659441")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementInformation13? SettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInformation13? SettlementInformation { get; init; } 
    #else
    public SettlementInformation13? SettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_P1c66Np-Ed-ak6NoX_4Aeg_441579681")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Type Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation22? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation22? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation22? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_P1mr4Np-Ed-ak6NoX_4Aeg_440658516")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentMethod4Code? PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMethod4Code? PaymentMethod { get; init; } 
    #else
    public PaymentMethod4Code? PaymentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_P1mr4dp-Ed-ak6NoX_4Aeg_440659163")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Mandate Related Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateRelatedInformation6? MandateRelatedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateRelatedInformation6? MandateRelatedInformation { get; init; } 
    #else
    public MandateRelatedInformation6? MandateRelatedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    [IsoId("_P1mr4tp-Ed-ak6NoX_4Aeg_440659132")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Remittance Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation5? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation5? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation5? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P1mr49p-Ed-ak6NoX_4Aeg_440658918")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ultimate Debtor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification32? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_P1mr5Np-Ed-ak6NoX_4Aeg_440658978")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? Debtor { get; init; } 
    #else
    public PartyIdentification32? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_P1mr5dp-Ed-ak6NoX_4Aeg_440659533")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? DebtorAccount { get; init; } 
    #else
    public CashAccount16? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_P1mr5tp-Ed-ak6NoX_4Aeg_-1180106960")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_P1mr59p-Ed-ak6NoX_4Aeg_441579619")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debtor Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? DebtorAgentAccount { get; init; } 
    #else
    public CashAccount16? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_P1mr6Np-Ed-ak6NoX_4Aeg_-1180106951")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Agent")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_P1mr6dp-Ed-ak6NoX_4Aeg_441579589")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Agent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? CreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? CreditorAgentAccount { get; init; } 
    #else
    public CashAccount16? CreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_P1wc4Np-Ed-ak6NoX_4Aeg_440659040")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? Creditor { get; init; } 
    #else
    public PartyIdentification32? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_P1wc4dp-Ed-ak6NoX_4Aeg_441579527")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creditor Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? CreditorAccount { get; init; } 
    #else
    public CashAccount16? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_P1wc4tp-Ed-ak6NoX_4Aeg_440659010")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ultimate Creditor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification32? UltimateCreditor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
