﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructionProcessingStatus4.  ISO2002 ID# _9DhyV6-nEemJ1NnLPsTFaw.
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
/// Status advising on the processing of the instruction.
/// </summary>
[IsoId("_9DhyV6-nEemJ1NnLPsTFaw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Instruction Processing Status")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionProcessingStatus4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructionProcessingStatus4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructionProcessingStatus4( Status8Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_9YNB0a-nEemJ1NnLPsTFaw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status8Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Status8Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status8Code Status { get; init; } 
    #else
    public Status8Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_9YNB06-nEemJ1NnLPsTFaw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
