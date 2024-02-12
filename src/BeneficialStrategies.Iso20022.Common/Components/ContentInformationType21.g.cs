﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContentInformationType21.  ISO2002 ID# _gkSEMQuhEeqw5uEXxQ9H4g.
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
/// General cryptographic message syntax (CMS) containing data. protected by a MAC or a digital signature.
/// </summary>
[IsoId("_gkSEMQuhEeqw5uEXxQ9H4g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Content Information Type")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContentInformationType21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContentInformationType21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContentInformationType21( ContentType2Code reqContentType )
    {
        ContentType = reqContentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_gvWEsQuhEeqw5uEXxQ9H4g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Content Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentType2Code ContentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ContentType2Code ContentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentType2Code ContentType { get; init; } 
    #else
    public ContentType2Code ContentType { get; set; } 
    #endif
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_gvWEswuhEeqw5uEXxQ9H4g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authenticated Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticatedData6? AuthenticatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticatedData6? AuthenticatedData { get; init; } 
    #else
    public AuthenticatedData6? AuthenticatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_gvWEtQuhEeqw5uEXxQ9H4g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Signed Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedData5? SignedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedData5? SignedData { get; init; } 
    #else
    public SignedData5? SignedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
