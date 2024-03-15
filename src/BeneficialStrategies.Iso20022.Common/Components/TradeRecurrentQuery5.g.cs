﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeRecurrentQuery5.  ISO2002 ID# _esoycd1dEeqxpKDfBZC1vg.
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
/// Recurrent query criteria.
/// </summary>
[IsoId("_esoycd1dEeqxpKDfBZC1vg")]
[DisplayName("Trade Recurrent Query")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeRecurrentQuery5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeRecurrentQuery5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeRecurrentQuery5( System.String reqQueryType,TradeQueryExecutionFrequency3 reqFrequency,System.DateOnly reqValidUntil )
    {
        QueryType = reqQueryType;
        Frequency = reqFrequency;
        ValidUntil = reqValidUntil;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the type of recurrent query which is requested.
    /// </summary>
    [IsoId("_et5Wsd1dEeqxpKDfBZC1vg")]
    [DisplayName("Query Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTp")]
    #endif
    [IsoXmlTag("QryTp")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax1000Text QueryType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QueryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QueryType { get; init; } 
    #else
    public System.String QueryType { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the requested frequency of the recurrent query.
    /// </summary>
    [IsoId("_et5Ws91dEeqxpKDfBZC1vg")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeQueryExecutionFrequency3 Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeQueryExecutionFrequency3 Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeQueryExecutionFrequency3 Frequency { get; init; } 
    #else
    public TradeQueryExecutionFrequency3 Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the date until which the query will be executed.
    /// </summary>
    [IsoId("_et5Wtd1dEeqxpKDfBZC1vg")]
    [DisplayName("Valid Until")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldUntil")]
    #endif
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValidUntil { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValidUntil { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValidUntil { get; init; } 
    #else
    public System.DateOnly ValidUntil { get; set; } 
    #endif
    
    
    #nullable disable
    
}
