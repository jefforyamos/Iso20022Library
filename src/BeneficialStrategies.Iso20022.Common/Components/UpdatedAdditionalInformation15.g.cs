﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdatedAdditionalInformation15.  ISO2002 ID# _x_UPKx9REeuFz_FaCzCLgQ.
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
/// Additional information with update description and date.
/// </summary>
[IsoId("_x_UPKx9REeuFz_FaCzCLgQ")]
[DisplayName("Updated Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdatedAdditionalInformation15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UpdatedAdditionalInformation15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UpdatedAdditionalInformation15( string reqLanguage )
    {
        Language = reqLanguage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Language used to provide additional information and using the ISO 639-1 language code standard.
    /// </summary>
    [IsoId("_x_UPLR9REeuFz_FaCzCLgQ")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISO2ALanguageCode Language { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Language { get; init; } 
    #else
    public string Language { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_x_UPLx9REeuFz_FaCzCLgQ")]
    [DisplayName("Update Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdDesc")]
    #endif
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? UpdateDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UpdateDescription { get; init; } 
    #else
    public System.String? UpdateDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_x_UPMR9REeuFz_FaCzCLgQ")]
    [DisplayName("Update Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdDt")]
    #endif
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? UpdateDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? UpdateDate { get; init; } 
    #else
    public System.DateOnly? UpdateDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    [IsoId("_x_UPMx9REeuFz_FaCzCLgQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public System.String? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _x_UPMx9REeuFz_FaCzCLgQ
    
    
    #nullable disable
    
}
