﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalOrderQuantityType1.  ISO2002 ID# _Uvt1e9p-Ed-ak6NoX_4Aeg_-1430220527.
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
/// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
/// </summary>
[IsoId("_Uvt1e9p-Ed-ak6NoX_4Aeg_-1430220527")]
[DisplayName("Original Order Quantity Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalOrderQuantityType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalOrderQuantityType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalOrderQuantityType1( OrderQuantityType1Code reqStructured )
    {
        Structured = reqStructured;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Order type, expressed as a code.
    /// </summary>
    [IsoId("_Uvt1fNp-Ed-ak6NoX_4Aeg_-1000782955")]
    [DisplayName("Structured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strd")]
    #endif
    [IsoXmlTag("Strd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderQuantityType1Code Structured { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderQuantityType1Code Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderQuantityType1Code Structured { get; init; } 
    #else
    public OrderQuantityType1Code Structured { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the order type.
    /// </summary>
    [IsoId("_Uv3mcNp-Ed-ak6NoX_4Aeg_-997087875")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
