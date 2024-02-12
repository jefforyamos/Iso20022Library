﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification90.  ISO2002 ID# _rkfJ4Y0YEeWRYffwL7E13A.
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
/// Identification of an entity.
/// </summary>
[IsoId("_rkfJ4Y0YEeWRYffwL7E13A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Generic Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericIdentification90
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericIdentification90 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericIdentification90( PartyType14Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_rvGecY0YEeWRYffwL7E13A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_rvGec40YEeWRYffwL7E13A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyType14Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyType14Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType14Code Type { get; init; } 
    #else
    public PartyType14Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_rvGedY0YEeWRYffwL7E13A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType4Code? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType4Code? Issuer { get; init; } 
    #else
    public PartyType4Code? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_rvGed40YEeWRYffwL7E13A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Country { get; init; } 
    #else
    public System.String? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_rvGeeY0YEeWRYffwL7E13A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Short Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
