﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalTransactionReference23.  ISO2002 ID# _wohsAYIWEeWs6fzahhkJjg.
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
[IsoId("_wohsAYIWEeWs6fzahhkJjg")]
[DisplayName("Original Transaction Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalTransactionReference23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalTransactionReference23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalTransactionReference23( BranchAndFinancialInstitutionIdentification5 reqCreditorAgent,PartyIdentification43 reqCreditor )
    {
        CreditorAgent = reqCreditorAgent;
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_wwLMI4IWEeWs6fzahhkJjg")]
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
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor&apos;s account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    [IsoId("_wwLMJYIWEeWs6fzahhkJjg")]
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
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_wwLMJ4IWEeWs6fzahhkJjg")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation19? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_wwLMKYIWEeWs6fzahhkJjg")]
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
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_wwLMK4IWEeWs6fzahhkJjg")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation11? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation11? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation11? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_wwLMLYIWEeWs6fzahhkJjg")]
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
    [IsoId("_wwLML4IWEeWs6fzahhkJjg")]
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
    [IsoId("_wwLMMYIWEeWs6fzahhkJjg")]
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
    [IsoId("_wwLMM4IWEeWs6fzahhkJjg")]
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
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_wwLMNYIWEeWs6fzahhkJjg")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_wwLMN4IWEeWs6fzahhkJjg")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 Creditor { get; init; } 
    #else
    public PartyIdentification43 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_wwLMOYIWEeWs6fzahhkJjg")]
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
    [IsoId("_wwLMO4IWEeWs6fzahhkJjg")]
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
