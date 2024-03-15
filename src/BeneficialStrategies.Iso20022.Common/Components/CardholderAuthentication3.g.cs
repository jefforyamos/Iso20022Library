﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardholderAuthentication3.  ISO2002 ID# _Fw2qQQvUEeKzJ69IWwzB9Q.
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
/// Data related to the authentication of the cardholder.
/// </summary>
[IsoId("_Fw2qQQvUEeKzJ69IWwzB9Q")]
[DisplayName("Cardholder Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderAuthentication3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardholderAuthentication3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardholderAuthentication3( AuthenticationMethod2Code reqAuthenticationMethod )
    {
        AuthenticationMethod = reqAuthenticationMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to authenticate a cardholder.
    /// </summary>
    [IsoId("_F8AxYQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnMtd")]
    #endif
    [IsoXmlTag("AuthntcnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthenticationMethod2Code AuthenticationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthenticationMethod2Code AuthenticationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod2Code AuthenticationMethod { get; init; } 
    #else
    public AuthenticationMethod2Code AuthenticationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    [IsoId("_F8AxZQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnNtty")]
    #endif
    [IsoXmlTag("AuthntcnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationEntity1Code? AuthenticationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationEntity1Code? AuthenticationEntity { get; init; } 
    #else
    public AuthenticationEntity1Code? AuthenticationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_F8AxaQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnVal")]
    #endif
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax40Text? AuthenticationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationValue { get; init; } 
    #else
    public System.String? AuthenticationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_F8AxbQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Cardholder On Line PIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrOnLinePIN")]
    #endif
    [IsoXmlTag("CrdhldrOnLinePIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLinePIN2? CardholderOnLinePIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLinePIN2? CardholderOnLinePIN { get; init; } 
    #else
    public OnLinePIN2? CardholderOnLinePIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies in electronic commerce transactions whether customer authentication is supported and data is available.
    /// </summary>
    [IsoId("_F8AxcQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication Collection Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnColltnInd")]
    #endif
    [IsoXmlTag("AuthntcnColltnInd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AuthenticationCollectionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationCollectionIndicator { get; init; } 
    #else
    public System.String? AuthenticationCollectionIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
