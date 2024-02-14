﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatusReason33.  ISO2002 ID# _5Bm5Ie6KEeqc-LCjwLsUVg.
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
/// Specifies reasons for the rejected status.
/// </summary>
[IsoId("_5Bm5Ie6KEeqc-LCjwLsUVg")]
[DisplayName("Rejected Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectedStatusReason33
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectedStatusReason33 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectedStatusReason33( RejectedReason35Choice_ reqReasonCode )
    {
        ReasonCode = reqReasonCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been rejected.
    /// </summary>
    [IsoId("_5rHJE-6KEeqc-LCjwLsUVg")]
    [DisplayName("Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnCd")]
    #endif
    [IsoXmlTag("RsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedReason35Choice_ ReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedReason35Choice_ ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedReason35Choice_ ReasonCode { get; init; } 
    #else
    public RejectedReason35Choice_ ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_5rHJG-6KEeqc-LCjwLsUVg")]
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
