﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NotificationUpdate1.  ISO2002 ID# _cLJsVK7REemG7MmivSuE5g.
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
/// Identification of a previous notification.
/// </summary>
[IsoId("_cLJsVK7REemG7MmivSuE5g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Notification Update")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotificationUpdate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NotificationUpdate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NotificationUpdate1( System.String reqPreviousNotificationIdentification,System.String reqReconfirmInstructions )
    {
        PreviousNotificationIdentification = reqPreviousNotificationIdentification;
        ReconfirmInstructions = reqReconfirmInstructions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a previously sent meeting notification message.
    /// </summary>
    [IsoId("_cLJsV67REemG7MmivSuE5g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Notification Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PreviousNotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String PreviousNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PreviousNotificationIdentification { get; init; } 
    #else
    public System.String PreviousNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a meeting instruction must be resent in case the parameters of the meeting are changed and the meeting instruction has already been sent.
    /// </summary>
    [IsoId("_cLJsVq7REemG7MmivSuE5g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reconfirm Instructions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ReconfirmInstructions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ReconfirmInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReconfirmInstructions { get; init; } 
    #else
    public System.String ReconfirmInstructions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
