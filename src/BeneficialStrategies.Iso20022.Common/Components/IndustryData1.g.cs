﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndustryData1.  ISO2002 ID# _3neKIOzXEeiojesOXOKoug.
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
/// Data container to exchange data elements defined by another standard.
/// </summary>
[IsoId("_3neKIOzXEeiojesOXOKoug")]
[DisplayName("Industry Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndustryData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndustryData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndustryData1( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the set of data to exchange.
    /// </summary>
    [IsoId("_Rro2oOzYEeiojesOXOKoug")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax1025Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Data to exchange according to an external standard.
    /// </summary>
    [IsoId("_nA6LEOzYEeiojesOXOKoug")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Value { get; init; } 
    #else
    public System.Byte[]? Value { get; set; } 
    #endif
    
    /// <summary>
    /// Protection of the values to exchange.
    /// </summary>
    [IsoId("_BFBNMOzZEeiojesOXOKoug")]
    [DisplayName("Protected Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdVal")]
    #endif
    [IsoXmlTag("PrtctdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType19? ProtectedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType19? ProtectedValue { get; init; } 
    #else
    public ContentInformationType19? ProtectedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the standard used to encode the values to exchange.
    /// </summary>
    [IsoId("_UzXnIOzZEeiojesOXOKoug")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
