﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceType2.  ISO2002 ID# _UQlCYtp-Ed-ak6NoX_4Aeg_1864790659.
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
/// Specification of the price type.
/// </summary>
[IsoId("_UQlCYtp-Ed-ak6NoX_4Aeg_1864790659")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Price Type")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceType2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceType2( TypeOfPrice6Code reqStructured )
    {
        Structured = reqStructured;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_UQlCY9p-Ed-ak6NoX_4Aeg_1890648274")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Structured")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice6Code Structured { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TypeOfPrice6Code Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice6Code Structured { get; init; } 
    #else
    public TypeOfPrice6Code Structured { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the type of charge.
    /// </summary>
    [IsoId("_UQlCZNp-Ed-ak6NoX_4Aeg_1890648275")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
