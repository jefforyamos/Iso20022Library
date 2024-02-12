﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInitialisationCardReaderRequest5.  ISO2002 ID# _JUhW8XGfEe2TbaNWBpRZpQ.
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
/// Specifies what to do during a card reader initialisation.
/// </summary>
[IsoId("_JUhW8XGfEe2TbaNWBpRZpQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Device Initialisation Card Reader Request")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInitialisationCardReaderRequest5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Flag to request a warm reset on a chip.
    /// </summary>
    [IsoId("_JaxI4XGfEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Warm Reset Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WarmResetFlag { get; init; } 
    #else
    public System.String? WarmResetFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("_JaxI43GfEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Force Entry Mode")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading8Code? ForceEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading8Code? ForceEntryMode { get; init; } 
    #else
    public CardDataReading8Code? ForceEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to indicate the POI System to keep the card in the reader for a smart card.
    /// </summary>
    [IsoId("_JaxI5XGfEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Leave Card Flag")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LeaveCardFlag { get; init; } 
    #else
    public System.String? LeaveCardFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum time in seconds that the POI has to wait for a card response.
    /// </summary>
    [IsoId("_JaxI53GfEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maximum Waiting Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumWaitingTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumWaitingTime { get; init; } 
    #else
    public System.UInt64? MaximumWaitingTime { get; set; } 
    #endif
    
    /// <summary>
    /// Information to display.
    /// </summary>
    [IsoId("_JaxI6XGfEe2TbaNWBpRZpQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Display Output")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? DisplayOutput { get; init; } 
    #else
    public ActionMessage10? DisplayOutput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
