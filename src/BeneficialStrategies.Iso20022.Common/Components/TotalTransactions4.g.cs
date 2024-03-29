﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalTransactions4.  ISO2002 ID# _kyJo0SGxEeKjd4jizyIDGA.
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
/// Set of elements used to provide summary information on entries.
/// </summary>
[IsoId("_kyJo0SGxEeKjd4jizyIDGA")]
[DisplayName("Total Transactions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalTransactions4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    [IsoId("_lH52YSGxEeKjd4jizyIDGA")]
    [DisplayName("Total Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNtries")]
    #endif
    [IsoXmlTag("TtlNtries")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions4? TotalEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions4? TotalEntries { get; init; } 
    #else
    public NumberAndSumOfTransactions4? TotalEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    [IsoId("_lH52ZSGxEeKjd4jizyIDGA")]
    [DisplayName("Total Credit Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCdtNtries")]
    #endif
    [IsoXmlTag("TtlCdtNtries")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; } 
    #else
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    [IsoId("_lH52aSGxEeKjd4jizyIDGA")]
    [DisplayName("Total Debit Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDbtNtries")]
    #endif
    [IsoXmlTag("TtlDbtNtries")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; } 
    #else
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    [IsoId("_lH52bSGxEeKjd4jizyIDGA")]
    [DisplayName("Total Entries Per Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNtriesPerBkTxCd")]
    #endif
    [IsoXmlTag("TtlNtriesPerBkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalsPerBankTransactionCode3? TotalEntriesPerBankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalsPerBankTransactionCode3? TotalEntriesPerBankTransactionCode { get; init; } 
    #else
    public TotalsPerBankTransactionCode3? TotalEntriesPerBankTransactionCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
