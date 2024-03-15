﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdateLogMarketSpecificAttribute1.  ISO2002 ID# _8g_CI2jSEeiRg5NzP0jkQg.
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
/// Specifies the old and new values for a market specific attribute.
/// </summary>
[IsoId("_8g_CI2jSEeiRg5NzP0jkQg")]
[DisplayName("Update Log Market Specific Attribute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdateLogMarketSpecificAttribute1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UpdateLogMarketSpecificAttribute1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UpdateLogMarketSpecificAttribute1( MarketSpecificAttribute1 reqOld,MarketSpecificAttribute1 reqNew )
    {
        Old = reqOld;
        New = reqNew;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_8g_pMWjSEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Od")]
    #endif
    [IsoXmlTag("Od")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketSpecificAttribute1 Old { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketSpecificAttribute1 Old { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketSpecificAttribute1 Old { get; init; } 
    #else
    public MarketSpecificAttribute1 Old { get; set; } 
    #endif
    
    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_8g_pMGjSEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="New")]
    #endif
    [IsoXmlTag("New")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketSpecificAttribute1 New { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketSpecificAttribute1 New { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketSpecificAttribute1 New { get; init; } 
    #else
    public MarketSpecificAttribute1 New { get; set; } 
    #endif
    
    
    #nullable disable
    
}
