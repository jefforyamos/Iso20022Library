﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification18.  ISO2002 ID# _el9wcID3EeSQoe-8fZQlpA.
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
/// Identification of a security by its symbol.
/// </summary>
[IsoId("_el9wcID3EeSQoe-8fZQlpA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Security Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIdentification18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIdentification18( IdentificationType2Code reqSecurityIdentificationSource,System.String reqSecurityIdentification )
    {
        SecurityIdentificationSource = reqSecurityIdentificationSource;
        SecurityIdentification = reqSecurityIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Security identification source of the trade.
    /// </summary>
    [IsoId("_q2VgcID4EeSQoe-8fZQlpA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification Source")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationType2Code SecurityIdentificationSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public IdentificationType2Code SecurityIdentificationSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationType2Code SecurityIdentificationSource { get; init; } 
    #else
    public IdentificationType2Code SecurityIdentificationSource { get; set; } 
    #endif
    
    /// <summary>
    /// Security identification of the trade.
    /// </summary>
    [IsoId("_vO8fcID4EeSQoe-8fZQlpA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecurityIdentification { get; init; } 
    #else
    public System.String SecurityIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
