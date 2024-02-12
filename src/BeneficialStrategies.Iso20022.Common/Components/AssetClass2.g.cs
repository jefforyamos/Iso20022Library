﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AssetClass2.  ISO2002 ID# _Hq0pRX5aEea2k7EBUopqxw.
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
/// Structure for defining asset class specific details of a derivative to be declared.
/// </summary>
[IsoId("_Hq0pRX5aEea2k7EBUopqxw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Asset Class")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AssetClass2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The fields in this section should only be populated for instruments that have non-financial instrument of type commodity as underlying.
    /// </summary>
    [IsoId("_HzdA035aEea2k7EBUopqxw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Commodity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeCommodity2? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeCommodity2? Commodity { get; init; } 
    #else
    public DerivativeCommodity2? Commodity { get; set; } 
    #endif
    
    /// <summary>
    /// The fields in this section should only be populated for instruments that have non-financial instrument of type interest rates as underlying.
    /// </summary>
    [IsoId("_HzdA1X5aEea2k7EBUopqxw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeInterest3? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeInterest3? Interest { get; init; } 
    #else
    public DerivativeInterest3? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// The fields in this section should only be populated for instruments that have non-financial instrument of type foreign exchange as underlying.
    /// </summary>
    [IsoId("_HzdA135aEea2k7EBUopqxw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Foreign Exchange")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeForeignExchange3? ForeignExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeForeignExchange3? ForeignExchange { get; init; } 
    #else
    public DerivativeForeignExchange3? ForeignExchange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
