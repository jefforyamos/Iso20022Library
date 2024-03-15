﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SuspendedStatusReason4.  ISO2002 ID# _d2qkoUHmEea8I67lh6qdSQ.
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
/// Reason for a suspended status.
/// </summary>
[IsoId("_d2qkoUHmEea8I67lh6qdSQ")]
[DisplayName("Suspended Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SuspendedStatusReason4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SuspendedStatusReason4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SuspendedStatusReason4( SuspendedStatusReason5Choice_ reqReason )
    {
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the conditionally accepted status expressed as a code.
    /// </summary>
    [IsoId("_eO6skUHmEea8I67lh6qdSQ")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SuspendedStatusReason5Choice_ Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SuspendedStatusReason5Choice_ Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SuspendedStatusReason5Choice_ Reason { get; init; } 
    #else
    public SuspendedStatusReason5Choice_ Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the suspended reason.
    /// </summary>
    [IsoId("_eO6sk0HmEea8I67lh6qdSQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
