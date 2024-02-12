﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification79.  ISO2002 ID# _Vyh485qLEeWcAIE4lEkF_Q.
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
/// Identification using a proprietary scheme.
/// </summary>
[IsoId("_Vyh485qLEeWcAIE4lEkF_Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Generic Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericIdentification79
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericIdentification79 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericIdentification79( System.String reqIdentification,System.String reqIssuer )
    {
        Identification = reqIdentification;
        Issuer = reqIssuer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_Vyh495qLEeWcAIE4lEkF_Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax34Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_Vyh4-ZqLEeWcAIE4lEkF_Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Issuer { get; init; } 
    #else
    public System.String Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_Vyh4-5qLEeWcAIE4lEkF_Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Scheme Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SchemeName { get; init; } 
    #else
    public System.String? SchemeName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
