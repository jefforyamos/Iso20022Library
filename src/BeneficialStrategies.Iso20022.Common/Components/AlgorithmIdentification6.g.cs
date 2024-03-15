﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification6.  ISO2002 ID# _6M32gQiuEeKn9O5oyej_zw.
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
/// Cryptographic algorithm and parameters for encryptions with a symmetric cryptographic key.
/// </summary>
[IsoId("_6M32gQiuEeKn9O5oyej_zw")]
[DisplayName("Algorithm Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlgorithmIdentification6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlgorithmIdentification6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlgorithmIdentification6( Algorithm6Code reqAlgorithm )
    {
        Algorithm = reqAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_6YxkhQiuEeKn9O5oyej_zw")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Algorithm6Code Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Algorithm6Code Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm6Code Algorithm { get; init; } 
    #else
    public Algorithm6Code Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters associated with the algorithm.
    /// </summary>
    [IsoId("_6YxkjAiuEeKn9O5oyej_zw")]
    [DisplayName("Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Param")]
    #endif
    [IsoXmlTag("Param")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Parameter1? Parameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Parameter1? Parameter { get; init; } 
    #else
    public Parameter1? Parameter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
