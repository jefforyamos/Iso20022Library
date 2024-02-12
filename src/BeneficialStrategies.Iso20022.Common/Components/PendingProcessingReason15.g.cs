﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingProcessingReason15.  ISO2002 ID# _6vhl4QpJEeup4r-PFG2T5Q.
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
/// Specifies the reason why the instruction or request has a pending processing status.
/// </summary>
[IsoId("_6vhl4QpJEeup4r-PFG2T5Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Pending Processing Reason")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PendingProcessingReason15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PendingProcessingReason15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PendingProcessingReason15( PendingProcessingReason17Choice_ reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    [IsoId("_68BwwQpJEeup4r-PFG2T5Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PendingProcessingReason17Choice_ Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PendingProcessingReason17Choice_ Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingProcessingReason17Choice_ Code { get; init; } 
    #else
    public PendingProcessingReason17Choice_ Code { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_68BwyQpJEeup4r-PFG2T5Q")]
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
