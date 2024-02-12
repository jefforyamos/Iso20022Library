﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccountCharacteristics1.  ISO2002 ID# _6RmCfpqlEeGSON8vddiWzQ_-1885901268.
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
/// Specifies the characteristics of the cash account.
/// </summary>
[IsoId("_6RmCfpqlEeGSON8vddiWzQ_-1885901268")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cash Account Characteristics")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccountCharacteristics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccountCharacteristics1( AccountLevel2Code reqAccountLevel,CashAccount16 reqCashAccount,CompensationMethod1Code reqCompensationMethod,string reqAccountBalanceCurrencyCode,ContactDetails3 reqAccountServicerContact )
    {
        AccountLevel = reqAccountLevel;
        CashAccount = reqCashAccount;
        CompensationMethod = reqCompensationMethod;
        AccountBalanceCurrencyCode = reqAccountBalanceCurrencyCode;
        AccountServicerContact = reqAccountServicerContact;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the account level within an account hierarchy.
    /// </summary>
    [IsoId("_6RvMYJqlEeGSON8vddiWzQ_598766931")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Level")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountLevel2Code AccountLevel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AccountLevel2Code AccountLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountLevel2Code AccountLevel { get; init; } 
    #else
    public AccountLevel2Code AccountLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_6RvMYZqlEeGSON8vddiWzQ_1529637333")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount16 CashAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CashAccount16 CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16 CashAccount { get; init; } 
    #else
    public CashAccount16 CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Usage: the account servicer is the domicile agent servicing the local account.
    /// </summary>
    [IsoId("_6RvMYpqlEeGSON8vddiWzQ_-1152772184")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Servicer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Defines a parent account to which the cash account is related to.
    /// </summary>
    [IsoId("_6RvMY5qlEeGSON8vddiWzQ_-974653512")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Parent Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ParentCashAccount1? ParentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ParentCashAccount1? ParentAccount { get; init; } 
    #else
    public ParentCashAccount1? ParentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines if and how charges and taxes due are paid to the financial institution.
    /// </summary>
    [IsoId("_6RvMZJqlEeGSON8vddiWzQ_-1838430112")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Compensation Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CompensationMethod1Code CompensationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CompensationMethod1Code CompensationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompensationMethod1Code CompensationMethod { get; init; } 
    #else
    public CompensationMethod1Code CompensationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the account debited for charges and taxes due on the cash account, if different from the cash account.
    /// </summary>
    [IsoId("_6RvMZZqlEeGSON8vddiWzQ_-193162677")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Debit Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    #else
    public AccountIdentification4Choice_? DebitAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Future date on which the account will be automatically debited for charges and taxes due.
    /// </summary>
    [IsoId("_6RvMZpqlEeGSON8vddiWzQ_1345625765")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delayed Debit Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DelayedDebitDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DelayedDebitDate { get; init; } 
    #else
    public System.DateOnly? DelayedDebitDate { get; set; } 
    #endif
    
    /// <summary>
    /// Free form message advising the customer about the settlement of charges and taxes due.
    /// </summary>
    [IsoId("_6RvMZ5qlEeGSON8vddiWzQ_717549851")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Advice")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? SettlementAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementAdvice { get; init; } 
    #else
    public System.String? SettlementAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Currency used to specify the account's balance currency.
    /// </summary>
    [IsoId("_6RvMaJqlEeGSON8vddiWzQ_-2069546215")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Balance Currency Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode AccountBalanceCurrencyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string AccountBalanceCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string AccountBalanceCurrencyCode { get; init; } 
    #else
    public string AccountBalanceCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency used to specify the account's settlement currency.
    /// </summary>
    [IsoId("_6R49YJqlEeGSON8vddiWzQ_-424278780")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Currency Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? SettlementCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrencyCode { get; init; } 
    #else
    public string? SettlementCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency used to specify the account's taxing host currency.
    /// </summary>
    [IsoId("_6R49YZqlEeGSON8vddiWzQ_1114509662")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Host Currency Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? HostCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? HostCurrencyCode { get; init; } 
    #else
    public string? HostCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Describes account taxing parameters.
    /// </summary>
    [IsoId("_6R49YpqlEeGSON8vddiWzQ_409395047")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountTax1? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountTax1? Tax { get; init; } 
    #else
    public AccountTax1? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Individual to contact at the financial institution's location regarding problems of a business nature.
    /// </summary>
    [IsoId("_6R49Y5qlEeGSON8vddiWzQ_2106192736")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Servicer Contact")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactDetails3 AccountServicerContact { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ContactDetails3 AccountServicerContact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactDetails3 AccountServicerContact { get; init; } 
    #else
    public ContactDetails3 AccountServicerContact { get; set; } 
    #endif
    
    
    #nullable disable
    
}
