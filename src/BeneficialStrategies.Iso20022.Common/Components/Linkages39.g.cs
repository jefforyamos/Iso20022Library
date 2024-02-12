﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages39.  ISO2002 ID# _lZL6YTt4EeW638lNyHKv7A.
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
/// Information related to a linked transaction.
/// </summary>
[IsoId("_lZL6YTt4EeW638lNyHKv7A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Linkages")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Linkages39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Linkages39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Linkages39( References46Choice_ reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_l5LCAzt4EeW638lNyHKv7A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Position")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition8Choice_? ProcessingPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition8Choice_? ProcessingPosition { get; init; } 
    #else
    public ProcessingPosition8Choice_? ProcessingPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_l5LCCzt4EeW638lNyHKv7A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber5Choice_? MessageNumber { get; init; } 
    #else
    public DocumentNumber5Choice_? MessageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_l5LCEzt4EeW638lNyHKv7A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References46Choice_ Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public References46Choice_ Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References46Choice_ Reference { get; init; } 
    #else
    public References46Choice_ Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_l5LCGzt4EeW638lNyHKv7A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reference Owner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification92Choice_? ReferenceOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification92Choice_? ReferenceOwner { get; init; } 
    #else
    public PartyIdentification92Choice_? ReferenceOwner { get; set; } 
    #endif
    
    
    #nullable disable
    
}
