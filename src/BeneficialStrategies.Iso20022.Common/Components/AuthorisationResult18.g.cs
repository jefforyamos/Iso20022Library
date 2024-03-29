﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorisationResult18.  ISO2002 ID# _SpVRMU7LEeyGi9JAv6wq7Q.
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
/// Outcome of the authorisation.
/// </summary>
[IsoId("_SpVRMU7LEeyGi9JAv6wq7Q")]
[DisplayName("Authorisation Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorisationResult18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthorisationResult18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthorisationResult18( ResponseType10 reqResponseToAuthorisation )
    {
        ResponseToAuthorisation = reqResponseToAuthorisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_SvgKoU7LEeyGi9JAv6wq7Q")]
    [DisplayName("Authorisation Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnNtty")]
    #endif
    [IsoXmlTag("AuthstnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification90? AuthorisationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification90? AuthorisationEntity { get; init; } 
    #else
    public GenericIdentification90? AuthorisationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_SvgKo07LEeyGi9JAv6wq7Q")]
    [DisplayName("Response To Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnToAuthstn")]
    #endif
    [IsoXmlTag("RspnToAuthstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType10 ResponseToAuthorisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType10 ResponseToAuthorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType10 ResponseToAuthorisation { get; init; } 
    #else
    public ResponseType10 ResponseToAuthorisation { get; set; } 
    #endif
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_SvgKpU7LEeyGi9JAv6wq7Q")]
    [DisplayName("Authorisation Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnCd")]
    #endif
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? AuthorisationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisationCode { get; init; } 
    #else
    public System.String? AuthorisationCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
