﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SingleTransport8.  ISO2002 ID# __F4NETckEeSaC-PiOaz_KQ.
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
/// Specifies individually each leg of a transport of goods.
/// </summary>
[IsoId("__F4NETckEeSaC-PiOaz_KQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Single Transport")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SingleTransport8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the transportation of goods by air.
    /// </summary>
    [IsoId("__bvvYTckEeSaC-PiOaz_KQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transport By Air")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByAir4? TransportByAir { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByAir4? TransportByAir { get; init; } 
    #else
    public TransportByAir4? TransportByAir { get; set; } 
    #endif
    
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("__bvvYzckEeSaC-PiOaz_KQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transport By Sea")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportBySea5? TransportBySea { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportBySea5? TransportBySea { get; init; } 
    #else
    public TransportBySea5? TransportBySea { get; set; } 
    #endif
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("__bvvZTckEeSaC-PiOaz_KQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transport By Road")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRoad4? TransportByRoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRoad4? TransportByRoad { get; init; } 
    #else
    public TransportByRoad4? TransportByRoad { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("__bvvZzckEeSaC-PiOaz_KQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transport By Rail")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRail4? TransportByRail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRail4? TransportByRail { get; init; } 
    #else
    public TransportByRail4? TransportByRail { get; set; } 
    #endif
    
    
    #nullable disable
    
}
