﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SingleTransport1.  ISO2002 ID# _U7V2qNp-Ed-ak6NoX_4Aeg_1604046421.
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
[IsoId("_U7V2qNp-Ed-ak6NoX_4Aeg_1604046421")]
[DisplayName("Single Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SingleTransport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_U7fnoNp-Ed-ak6NoX_4Aeg_2015935953")]
    [DisplayName("Transport By Air")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByAir")]
    #endif
    [IsoXmlTag("TrnsprtByAir")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByAir1? TransportByAir { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByAir1? TransportByAir { get; init; } 
    #else
    public TransportByAir1? TransportByAir { get; set; } 
    #endif
    
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("_U7fnodp-Ed-ak6NoX_4Aeg_2030713576")]
    [DisplayName("Transport By Sea")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtBySea")]
    #endif
    [IsoXmlTag("TrnsprtBySea")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportBySea1? TransportBySea { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportBySea1? TransportBySea { get; init; } 
    #else
    public TransportBySea1? TransportBySea { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the transportation of goods by road.
    /// </summary>
    [IsoId("_U7fnotp-Ed-ak6NoX_4Aeg_2027019443")]
    [DisplayName("Transport By Road")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByRoad")]
    #endif
    [IsoXmlTag("TrnsprtByRoad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRoad1? TransportByRoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRoad1? TransportByRoad { get; init; } 
    #else
    public TransportByRoad1? TransportByRoad { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("_U7fno9p-Ed-ak6NoX_4Aeg_2035329660")]
    [DisplayName("Transport By Rail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByRail")]
    #endif
    [IsoXmlTag("TrnsprtByRail")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRail1? TransportByRail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRail1? TransportByRail { get; init; } 
    #else
    public TransportByRail1? TransportByRail { get; set; } 
    #endif
    
    
    #nullable disable
    
}
