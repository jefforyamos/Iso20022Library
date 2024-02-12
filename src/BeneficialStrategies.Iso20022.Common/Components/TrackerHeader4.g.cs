﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerHeader4.  ISO2002 ID# _k0GN8_Y0Eemf4dJxCjghNw.
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
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_k0GN8_Y0Eemf4dJxCjghNw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Tracker Header")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerHeader4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerHeader4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerHeader4( System.String reqMessageIdentification,System.DateTime reqCreationDateTime )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the tracker informing party and sent by the tracker to unambiguously identify the message.
    /// </summary>
    [IsoId("_k0GN9fY0Eemf4dJxCjghNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_k0GN9_Y0Eemf4dJxCjghNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creation Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Original reference, as assigned by the informer and sent to the tracker to unambiguously identify the tracker update message.
    /// Usage: this element may only be present when the alert notification is related to a payment status tracker update.
    /// </summary>
    [IsoId("_k0GN__Y0Eemf4dJxCjghNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Tracker Update")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessInstruction3? OriginalTrackerUpdate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessInstruction3? OriginalTrackerUpdate { get; init; } 
    #else
    public OriginalBusinessInstruction3? OriginalTrackerUpdate { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the tracker update must be processed.
    /// </summary>
    [IsoId("_k0GOAfY0Eemf4dJxCjghNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Level")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionServiceLevel1? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionServiceLevel1? ServiceLevel { get; init; } 
    #else
    public TransactionServiceLevel1? ServiceLevel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
