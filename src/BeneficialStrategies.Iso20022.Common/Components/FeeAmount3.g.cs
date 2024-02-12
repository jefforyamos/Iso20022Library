﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FeeAmount3.  ISO2002 ID# _pFtW8ZF2EeukDPgU2BMkjQ.
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
/// Amount, currency, exchange rate and quotation date, sign and label.
/// </summary>
[IsoId("_pFtW8ZF2EeukDPgU2BMkjQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Fee Amount")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FeeAmount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FeeAmount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FeeAmount3( System.Decimal reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount exclusive of currency.
    /// </summary>
    [IsoId("_pMXYkZF2EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Contains code list for a credit or debit transaction
    /// </summary>
    [IsoId("_436O8JF3EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Credit Debit")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebit3Code? CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebit3Code? CreditDebit { get; init; } 
    #else
    public CreditDebit3Code? CreditDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Currency for the type of amount.
    /// </summary>
    [IsoId("_pMXYk5F2EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate of the currency code associated with the amount. 
    /// </summary>
    [IsoId("_pMXYlZF2EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Effective Exchange Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOne25Rate? EffectiveExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EffectiveExchangeRate { get; init; } 
    #else
    public System.Decimal? EffectiveExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the exchange rate effective.
    /// </summary>
    [IsoId("_pMXYl5F2EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Conversion Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ConversionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ConversionDate { get; init; } 
    #else
    public System.DateOnly? ConversionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the exchange rate effective.
    /// </summary>
    [IsoId("_65GgEJF2EeukDPgU2BMkjQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Conversion Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ConversionTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ConversionTime { get; init; } 
    #else
    public System.TimeOnly? ConversionTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
