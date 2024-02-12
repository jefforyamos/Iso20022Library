﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedError1.  ISO2002 ID# _fOv6QFW5EeeiG_nL4vgKnQ.
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
/// Detailed description of an error that caused the message to be corrected/amended. Transmitted for further analysis.
/// </summary>
[IsoId("_fOv6QFW5EeeiG_nL4vgKnQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Detailed Error")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedError1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedError1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedError1( System.String reqType,System.String reqDescription )
    {
        Type = reqType;
        Description = reqDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of error corrected or amendment brought to the message.
    /// </summary>
    [IsoId("_31-HoFW5EeeiG_nL4vgKnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed description of the error or amendment.
    /// </summary>
    [IsoId("_-4ERYFW5EeeiG_nL4vgKnQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax500Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the modified value. 
    /// </summary>
    [IsoId("__lVpEGdsEem-ycRQGen_YA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Value { get; init; } 
    #else
    public System.String? Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
