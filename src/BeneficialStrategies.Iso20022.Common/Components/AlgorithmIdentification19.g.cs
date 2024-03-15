﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification19.  ISO2002 ID# _m4fhods2Eee9e6xduATmQg.
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
/// Cryptographic algorithms and parameters for the protection of transported keys by an asymmetric key.
/// </summary>
[IsoId("_m4fhods2Eee9e6xduATmQg")]
[DisplayName("Algorithm Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlgorithmIdentification19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlgorithmIdentification19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlgorithmIdentification19( Algorithm7Code reqAlgorithm )
    {
        Algorithm = reqAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Asymmetric encryption algorithm of a transport key.
    /// </summary>
    [IsoId("_nCNeUds2Eee9e6xduATmQg")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Algorithm7Code Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Algorithm7Code Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm7Code Algorithm { get; init; } 
    #else
    public Algorithm7Code Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters of the encryption algorithm.
    /// </summary>
    [IsoId("_nCNeU9s2Eee9e6xduATmQg")]
    [DisplayName("Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Param")]
    #endif
    [IsoXmlTag("Param")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Parameter10? Parameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Parameter10? Parameter { get; init; } 
    #else
    public Parameter10? Parameter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
