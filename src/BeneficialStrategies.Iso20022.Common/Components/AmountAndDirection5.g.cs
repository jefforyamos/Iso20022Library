﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection5.  ISO2002 ID# _T2Wkhdp-Ed-ak6NoX_4Aeg_-2124038249.
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
/// Amount of money debited or credited on the books of an account servicer.
/// </summary>
[IsoId("_T2Wkhdp-Ed-ak6NoX_4Aeg_-2124038249")]
[DisplayName("Amount And Direction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndDirection5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountAndDirection5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountAndDirection5( ActiveCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money that is debited or credited.
    /// </summary>
    [IsoId("_T2Wkhtp-Ed-ak6NoX_4Aeg_-2090791440")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the amount is a debited or a credited.
    /// </summary>
    [IsoId("_T2Wkh9p-Ed-ak6NoX_4Aeg_-2037226790")]
    [DisplayName("Credit Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbt")]
    #endif
    [IsoXmlTag("CdtDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebit { get; init; } 
    #else
    public CreditDebitCode? CreditDebit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
