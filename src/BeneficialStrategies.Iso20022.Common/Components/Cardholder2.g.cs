﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cardholder2.  ISO2002 ID# _SqbqzAEcEeCQm6a_G2yO_w_912220241.
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
/// Data related to the cardholder.
/// </summary>
[IsoId("_SqbqzAEcEeCQm6a_G2yO_w_912220241")]
[DisplayName("Cardholder")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cardholder2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_SqbqzQEcEeCQm6a_G2yO_w_-1648920024")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderIdentification1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderIdentification1? Identification { get; init; } 
    #else
    public CardholderIdentification1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_SqbqzgEcEeCQm6a_G2yO_w_-280784447")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax45Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the authentication of the cardholder.
    /// </summary>
    [IsoId("_Sqk0sAEcEeCQm6a_G2yO_w_-916509742")]
    [DisplayName("Authentication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authntcn")]
    #endif
    [IsoXmlTag("Authntcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderAuthentication2? Authentication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderAuthentication2? Authentication { get; init; } 
    #else
    public CardholderAuthentication2? Authentication { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s address for verification.
    /// </summary>
    [IsoId("_Sqk0sQEcEeCQm6a_G2yO_w_799334401")]
    [DisplayName("Address Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrVrfctn")]
    #endif
    [IsoXmlTag("AdrVrfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressVerification1? AddressVerification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressVerification1? AddressVerification { get; init; } 
    #else
    public AddressVerification1? AddressVerification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_Sqk0sgEcEeCQm6a_G2yO_w_-1277856800")]
    [DisplayName("Personal Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnlData")]
    #endif
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? PersonalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PersonalData { get; init; } 
    #else
    public System.String? PersonalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
