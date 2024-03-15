﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegistrationReason3.  ISO2002 ID# _zxI48RXZEeGmOJpfhCvx_g.
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
/// Reason of registration.
/// </summary>
[IsoId("_zxI48RXZEeGmOJpfhCvx_g")]
[DisplayName("Registration Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegistrationReason3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegistrationReason3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegistrationReason3( Registration7Choice_ reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reaoson of the holding status.
    /// </summary>
    [IsoId("_zxSp8RXZEeGmOJpfhCvx_g")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Registration7Choice_ Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Registration7Choice_ Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Registration7Choice_ Code { get; init; } 
    #else
    public Registration7Choice_ Code { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_zxSp9RXZEeGmOJpfhCvx_g")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
