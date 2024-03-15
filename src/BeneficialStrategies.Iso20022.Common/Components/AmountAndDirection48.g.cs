﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection48.  ISO2002 ID# __3lmbTp8EeWVrPy0StzzSg.
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
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("__3lmbTp8EeWVrPy0StzzSg")]
[DisplayName("Amount And Direction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndDirection48
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountAndDirection48 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountAndDirection48( System.Decimal reqAmount,CreditDebitCode reqCreditDebitIndicator )
    {
        Amount = reqAmount;
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_AWPRNTp9EeWVrPy0StzzSg")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_AWPRPTp9EeWVrPy0StzzSg")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_AWPRRTp9EeWVrPy0StzzSg")]
    [DisplayName("Original Currency And Ordered Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCcyAndOrdrdAmt")]
    #endif
    [IsoXmlTag("OrgnlCcyAndOrdrdAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OriginalCurrencyAndOrderedAmount { get; init; } 
    #else
    public System.Decimal? OriginalCurrencyAndOrderedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_AWPRTTp9EeWVrPy0StzzSg")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_AWPRVTp9EeWVrPy0StzzSg")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ValueDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
