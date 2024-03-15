﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIdentification21.  ISO2002 ID# _VygD6ZqLEeWcAIE4lEkF_Q.
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
/// Identification of a security.
/// </summary>
[IsoId("_VygD6ZqLEeWcAIE4lEkF_Q")]
[DisplayName("Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_VygD9ZqLEeWcAIE4lEkF_Q")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISIN { get; init; } 
    #else
    public System.String? ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_Vygq0ZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2? OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2? OtherIdentification { get; init; } 
    #else
    public OtherIdentification2? OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Textual description of a security instrument.
    /// </summary>
    [IsoId("_Vygq05qLEeWcAIE4lEkF_Q")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
