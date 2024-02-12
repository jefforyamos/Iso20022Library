﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingStatusReason22.  ISO2002 ID# _gKMmERHpEeuE0Pnt-OcNOA.
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
/// Specifies reasons for the pending status.
/// </summary>
[IsoId("_gKMmERHpEeuE0Pnt-OcNOA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Pending Status Reason")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PendingStatusReason22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PendingStatusReason22 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PendingStatusReason22( PendingReason59Choice_ reqReasonCode )
    {
        ReasonCode = reqReasonCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction's processing is pending.
    /// </summary>
    [IsoId("_glk6cxHpEeuE0Pnt-OcNOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PendingReason59Choice_ ReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PendingReason59Choice_ ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingReason59Choice_ ReasonCode { get; init; } 
    #else
    public PendingReason59Choice_ ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_glk6exHpEeuE0Pnt-OcNOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Reason Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
