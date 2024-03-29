﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxEfficientProduct6.  ISO2002 ID# __yVzAZNNEemQB_8XA98K0Q.
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
/// Characteristics of a tax efficient product.
/// </summary>
[IsoId("__yVzAZNNEemQB_8XA98K0Q")]
[DisplayName("Tax Efficient Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxEfficientProduct6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxEfficientProduct6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxEfficientProduct6( TaxEfficientProductType2Choice_ reqTaxEfficientProductType )
    {
        TaxEfficientProductType = reqTaxEfficientProductType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_AO5zM5NOEemQB_8XA98K0Q")]
    [DisplayName("Tax Efficient Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxEffcntPdctTp")]
    #endif
    [IsoXmlTag("TaxEffcntPdctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; } 
    #else
    public TaxEfficientProductType2Choice_ TaxEfficientProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that all the current fiscal year’s products are to be included.
    /// </summary>
    [IsoId("_8OMPcZNQEemQB_8XA98K0Q")]
    [DisplayName("Current Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYr")]
    #endif
    [IsoXmlTag("CurYr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CurrentYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrentYear { get; init; } 
    #else
    public System.String? CurrentYear { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the product contains a cash asset for transfer.
    /// </summary>
    [IsoId("_AO5zNZNOEemQB_8XA98K0Q")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashComponentIndicator { get; init; } 
    #else
    public System.String? CashComponentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_AO5zN5NOEemQB_8XA98K0Q")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreviousYear4? PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYear4? PreviousYears { get; init; } 
    #else
    public PreviousYear4? PreviousYears { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_AO5zOZNOEemQB_8XA98K0Q")]
    [DisplayName("Current Year Subscription Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYrSbcptDtls")]
    #endif
    [IsoXmlTag("CurYrSbcptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; } 
    #else
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_AO5zO5NOEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
