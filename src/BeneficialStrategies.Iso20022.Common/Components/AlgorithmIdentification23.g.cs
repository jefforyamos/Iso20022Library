﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification23.  ISO2002 ID# _iUbKodtkEee9e6xduATmQg.
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
/// Cryptographic algorithm and parameters for the protection of the transported key.
/// </summary>
[IsoId("_iUbKodtkEee9e6xduATmQg")]
[DisplayName("Algorithm Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlgorithmIdentification23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlgorithmIdentification23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlgorithmIdentification23( Algorithm18Code reqAlgorithm )
    {
        Algorithm = reqAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_id6d0dtkEee9e6xduATmQg")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Algorithm18Code Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Algorithm18Code Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm18Code Algorithm { get; init; } 
    #else
    public Algorithm18Code Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters associated to the encryption algorithm.
    /// </summary>
    [IsoId("_id6d09tkEee9e6xduATmQg")]
    [DisplayName("Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Param")]
    #endif
    [IsoXmlTag("Param")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Parameter12? Parameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Parameter12? Parameter { get; init; } 
    #else
    public Parameter12? Parameter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
