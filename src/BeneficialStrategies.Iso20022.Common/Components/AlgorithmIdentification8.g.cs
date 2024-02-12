﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification8.  ISO2002 ID# _KpAzMQusEeK6BpGAixa3eA.
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
/// Mask generator function cryptographic algorithm and parameters.
/// </summary>
[IsoId("_KpAzMQusEeK6BpGAixa3eA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Algorithm Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlgorithmIdentification8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlgorithmIdentification8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlgorithmIdentification8( Algorithm8Code reqAlgorithm )
    {
        Algorithm = reqAlgorithm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_K1NcIQusEeK6BpGAixa3eA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Algorithm")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Algorithm8Code Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Algorithm8Code Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm8Code Algorithm { get; init; } 
    #else
    public Algorithm8Code Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters associated to the mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_K1NcJQusEeK6BpGAixa3eA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Parameter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Parameter3? Parameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Parameter3? Parameter { get; init; } 
    #else
    public Parameter3? Parameter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
