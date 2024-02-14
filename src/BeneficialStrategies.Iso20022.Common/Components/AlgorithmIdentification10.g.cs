﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification10.  ISO2002 ID# _ckn7wTF2EeO118ZQJgaQSQ.
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
/// Identification of a cryptographic algorithm and parameters for the MAC computation.
/// </summary>
[IsoId("_ckn7wTF2EeO118ZQJgaQSQ")]
[DisplayName("Algorithm Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlgorithmIdentification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlgorithmIdentification10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlgorithmIdentification10( Algorithm10Code reqAlgorithm )
    {
        Algorithm = reqAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_c1bX4TF2EeO118ZQJgaQSQ")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Algorithm10Code Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Algorithm10Code Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm10Code Algorithm { get; init; } 
    #else
    public Algorithm10Code Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    [IsoId("_c1bX4zF2EeO118ZQJgaQSQ")]
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
