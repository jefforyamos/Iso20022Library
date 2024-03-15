﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareTerminationOption2.  ISO2002 ID# _GieqUdSaEemZdYGWu384Zw.
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
/// Specifies two values to compare for a termination option.
/// </summary>
[IsoId("_GieqUdSaEemZdYGWu384Zw")]
[DisplayName("Compare Termination Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CompareTerminationOption2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_GoekodSaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val1")]
    #endif
    [IsoXmlTag("Val1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepoTerminationOption2Code? Value1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepoTerminationOption2Code? Value1 { get; init; } 
    #else
    public RepoTerminationOption2Code? Value1 { get; set; } 
    #endif
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_Goeko9SaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val2")]
    #endif
    [IsoXmlTag("Val2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepoTerminationOption2Code? Value2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepoTerminationOption2Code? Value2 { get; init; } 
    #else
    public RepoTerminationOption2Code? Value2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
