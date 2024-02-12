﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlternatePartyIdentification7.  ISO2002 ID# _A7zZ3R5gEeWE3PufGMdJ3w.
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
/// Alternate identification for a party using an identification type, a country code and a text field.
/// </summary>
[IsoId("_A7zZ3R5gEeWE3PufGMdJ3w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Alternate Party Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlternatePartyIdentification7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlternatePartyIdentification7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlternatePartyIdentification7( IdentificationType42Choice_ reqIdentificationType,string reqCountry,System.String reqAlternateIdentification )
    {
        IdentificationType = reqIdentificationType;
        Country = reqCountry;
        AlternateIdentification = reqAlternateIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of alternate identification of the party identified.
    /// </summary>
    [IsoId("_BbMrdR5gEeWE3PufGMdJ3w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationType42Choice_ IdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public IdentificationType42Choice_ IdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationType42Choice_ IdentificationType { get; init; } 
    #else
    public IdentificationType42Choice_ IdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which a person resides (the place of a person's home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_BbMrfR5gEeWE3PufGMdJ3w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_BbMrhR5gEeWE3PufGMdJ3w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Alternate Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AlternateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AlternateIdentification { get; init; } 
    #else
    public System.String AlternateIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
