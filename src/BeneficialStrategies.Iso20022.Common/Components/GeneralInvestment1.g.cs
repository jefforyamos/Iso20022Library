﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralInvestment1.  ISO2002 ID# _e_q3UE4NEeiQHa-q1Uephw.
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
/// Information about a general investment.
/// </summary>
[IsoId("_e_q3UE4NEeiQHa-q1Uephw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("General Investment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralInvestment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of investment.
    /// </summary>
    [IsoId("_lboOIE4NEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GeneralInvestmentAccountType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeneralInvestmentAccountType1Choice_? Type { get; init; } 
    #else
    public GeneralInvestmentAccountType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money invested.
    /// </summary>
    [IsoId("_JnLksqqwEeirN7VYUwRpeQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Current Investment Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CurrentInvestmentAmount { get; init; } 
    #else
    public System.Decimal? CurrentInvestmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated value of the assets.
    /// </summary>
    [IsoId("_JnLks6qwEeirN7VYUwRpeQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Estimated Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? EstimatedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? EstimatedValue { get; init; } 
    #else
    public DateAndAmount2? EstimatedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the portfolio.
    /// </summary>
    [IsoId("_yHL6wE4NEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
