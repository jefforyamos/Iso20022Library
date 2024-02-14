﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryPrice2.  ISO2002 ID# _Rpr4pNp-Ed-ak6NoX_4Aeg_1562404369.
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
/// Set of elements used to identify a proprietary price.
/// </summary>
[IsoId("_Rpr4pNp-Ed-ak6NoX_4Aeg_1562404369")]
[DisplayName("Proprietary Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProprietaryPrice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProprietaryPrice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProprietaryPrice2( System.String reqType,System.Decimal reqPrice )
    {
        Type = reqType;
        Price = reqPrice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price.
    /// </summary>
    [IsoId("_Rpr4pdp-Ed-ak6NoX_4Aeg_1562404617")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    [IsoId("_Rpr4ptp-Ed-ak6NoX_4Aeg_1562404671")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveOrHistoricCurrencyAndAmount Price { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Price { get; init; } 
    #else
    public System.Decimal Price { get; set; } 
    #endif
    
    
    #nullable disable
    
}
