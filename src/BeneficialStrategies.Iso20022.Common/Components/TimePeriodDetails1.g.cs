﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TimePeriodDetails1.  ISO2002 ID# _T-_jK9p-Ed-ak6NoX_4Aeg_808787168.
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
/// Particular time span specified between a start time and an end time. The time period cannot exceed 24 hours.
/// </summary>
[IsoId("_T-_jK9p-Ed-ak6NoX_4Aeg_808787168")]
[DisplayName("Time Period Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TimePeriodDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TimePeriodDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TimePeriodDetails1( System.TimeOnly reqFromTime )
    {
        FromTime = reqFromTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Time at which the time span starts.
    /// </summary>
    [IsoId("_T-_jLNp-Ed-ak6NoX_4Aeg_808787185")]
    [DisplayName("From Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrTm")]
    #endif
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime FromTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly FromTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly FromTime { get; init; } 
    #else
    public System.TimeOnly FromTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the time span ends.
    /// </summary>
    [IsoId("_T_JUINp-Ed-ak6NoX_4Aeg_808787220")]
    [DisplayName("To Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToTm")]
    #endif
    [IsoXmlTag("ToTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ToTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ToTime { get; init; } 
    #else
    public System.TimeOnly? ToTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
