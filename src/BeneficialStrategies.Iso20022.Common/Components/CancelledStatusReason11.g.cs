﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancelledStatusReason11.  ISO2002 ID# _w-u9kUGUEeWqy4niLuXETA.
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
/// Specifies reasons for the cancelled status.
/// </summary>
[IsoId("_w-u9kUGUEeWqy4niLuXETA")]
[DisplayName("Cancelled Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelledStatusReason11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancelledStatusReason11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelledStatusReason11( CancelledReason8Choice_ reqReasonCode )
    {
        ReasonCode = reqReasonCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
    /// </summary>
    [IsoId("_xMRqQ0GUEeWqy4niLuXETA")]
    [DisplayName("Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnCd")]
    #endif
    [IsoXmlTag("RsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledReason8Choice_ ReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledReason8Choice_ ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledReason8Choice_ ReasonCode { get; init; } 
    #else
    public CancelledReason8Choice_ ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_xMRqS0GUEeWqy4niLuXETA")]
    [DisplayName("Additional Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRsnInf")]
    #endif
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
