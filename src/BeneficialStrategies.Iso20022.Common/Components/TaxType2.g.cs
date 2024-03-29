﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxType2.  ISO2002 ID# _VR2SJtp-Ed-ak6NoX_4Aeg_880118069.
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
/// Specification of the tax type.
/// </summary>
[IsoId("_VR2SJtp-Ed-ak6NoX_4Aeg_880118069")]
[DisplayName("Tax Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxType2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxType2( TaxType5Code reqStructured )
    {
        Structured = reqStructured;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VR2SJ9p-Ed-ak6NoX_4Aeg_979857984")]
    [DisplayName("Structured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strd")]
    #endif
    [IsoXmlTag("Strd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType5Code Structured { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxType5Code Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType5Code Structured { get; init; } 
    #else
    public TaxType5Code Structured { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VR2SKNp-Ed-ak6NoX_4Aeg_979858226")]
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
