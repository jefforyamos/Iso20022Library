﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommodityDerivate4.  ISO2002 ID# _zeGjUWlHEeaLAKoEUNsD9g.
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
/// Transparency calculation specific details for an commodity derivatives.
/// </summary>
[IsoId("_zeGjUWlHEeaLAKoEUNsD9g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Commodity Derivate")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommodityDerivate4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommodityDerivate4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommodityDerivate4( string reqNotionalCurrency )
    {
        NotionalCurrency = reqNotionalCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    [IsoId("_znHVYWlHEeaLAKoEUNsD9g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Class Specific")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommodityDerivate2Choice_? ClassSpecific { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommodityDerivate2Choice_? ClassSpecific { get; init; } 
    #else
    public CommodityDerivate2Choice_? ClassSpecific { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_znHVY2lHEeaLAKoEUNsD9g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notional Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string NotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string NotionalCurrency { get; init; } 
    #else
    public string NotionalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
