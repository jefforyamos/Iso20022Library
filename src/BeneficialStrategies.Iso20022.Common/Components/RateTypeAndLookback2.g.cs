﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndLookback2.  ISO2002 ID# _KwT9gRIlEeyLzJfz3xPQNA.
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
/// Specifies the pricing expressed as a rate type or a rate name complemented with lookback and crystallization days.
/// </summary>
[IsoId("_KwT9gRIlEeyLzJfz3xPQNA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Rate Type And Lookback")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateTypeAndLookback2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RateTypeAndLookback2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RateTypeAndLookback2( BenchmarkCurveName13Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the rate type as an index type or by its name.
    /// </summary>
    [IsoId("_LIAr0RIlEeyLzJfz3xPQNA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BenchmarkCurveName13Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BenchmarkCurveName13Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BenchmarkCurveName13Choice_ Type { get; init; } 
    #else
    public BenchmarkCurveName13Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days prior to the current day to source the rate.
    /// </summary>
    [IsoId("_LIAr0xIlEeyLzJfz3xPQNA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Look Back Days")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? LookBackDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LookBackDays { get; init; } 
    #else
    public System.String? LookBackDays { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the penultimate accrual date of the transaction to the final (repurchase) date. Crystallising the penultimate fixing into a fixed rate for the final business day. This will allow for parties to send timely settlement instructions for the repurchase leg of the transaction. Default value is 1 day.
    /// </summary>
    [IsoId("_LIAr1RIlEeyLzJfz3xPQNA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Crystallisation Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CrystallisationDay1? CrystallisationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CrystallisationDay1? CrystallisationDate { get; init; } 
    #else
    public CrystallisationDay1? CrystallisationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the tenor of the interest rate index (when the interest rate is calculated).
    /// </summary>
    [IsoId("_LIAr1xIlEeyLzJfz3xPQNA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tenor")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateIndexTenor2Code? Tenor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateIndexTenor2Code? Tenor { get; init; } 
    #else
    public InterestRateIndexTenor2Code? Tenor { get; set; } 
    #endif
    
    /// <summary>
    /// Rate Index currency.
    /// </summary>
    [IsoId("_LIAr2RIlEeyLzJfz3xPQNA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
