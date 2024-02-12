﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction132.  ISO2002 ID# _nNkNAYv5EeumSPwlS1PkxQ.
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
/// Inquiry transaction
/// </summary>
[IsoId("_nNkNAYv5EeumSPwlS1PkxQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction132
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction132 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction132( string reqTransactionType,TransactionIdentification18 reqTransactionIdentification )
    {
        TransactionType = reqTransactionType;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see "Transaction type codes" in ISO 8583 "Financial transaction card originated messages — Interchange message specifications"
    /// </summary>
    [IsoId("_nTf14Yv5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISO8583TransactionTypeCode TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string TransactionType { get; init; } 
    #else
    public string TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_nTf144v5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Sub Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSubType { get; init; } 
    #else
    public System.String? TransactionSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_wU8JIbXmEeusf7oR9YukCg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Service")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalService2? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalService2? AdditionalService { get; init; } 
    #else
    public AdditionalService2? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_nTf15Yv5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Special Programme Qualification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #else
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_nTf154v5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification18 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransactionIdentification18 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification18 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification18 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    [IsoId("_nTf16Yv5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reconciliation Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount15? ReconciliationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount15? ReconciliationAmount { get; init; } 
    #else
    public Amount15? ReconciliationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_nTf164v5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalAmounts3? AdditionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalAmounts3? AdditionalAmount { get; init; } 
    #else
    public AdditionalAmounts3? AdditionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_nTgc8Yv5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Fee")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of an account.
    /// </summary>
    [IsoId("_nTgc84v5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalance2? AccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalance2? AccountBalance { get; init; } 
    #else
    public AccountBalance2? AccountBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Account information of a statement of account.
    /// </summary>
    [IsoId("_nTgc9Yv5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Statement Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountStatementData2? AccountStatementData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatementData2? AccountStatementData { get; init; } 
    #else
    public AccountStatementData2? AccountStatementData { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_nTgc94v5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account From")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDetails3? AccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDetails3? AccountFrom { get; init; } 
    #else
    public AccountDetails3? AccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_nTgc-Yv5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? TransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionDescription { get; init; } 
    #else
    public System.String? TransactionDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_nTgc-4v5EeumSPwlS1PkxQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
