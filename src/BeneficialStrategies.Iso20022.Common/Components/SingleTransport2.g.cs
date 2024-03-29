﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SingleTransport2.  ISO2002 ID# _U7fnpNp-Ed-ak6NoX_4Aeg_-2082710326.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
[IsoId("_U7fnpNp-Ed-ak6NoX_4Aeg_-2082710326")]
[DisplayName("Single Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SingleTransport2
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
    [IsoId("_U7fnpdp-Ed-ak6NoX_4Aeg_-1668050769")]
    [DisplayName("Transport By Air")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByAir")]
    #endif
    [IsoXmlTag("TrnsprtByAir")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByAir2? TransportByAir { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByAir2? TransportByAir { get; init; } 
    #else
    public TransportByAir2? TransportByAir { get; set; } 
    #endif
    
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("_U7fnptp-Ed-ak6NoX_4Aeg_-1679131651")]
    [DisplayName("Transport By Sea")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtBySea")]
    #endif
    [IsoXmlTag("TrnsprtBySea")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportBySea2? TransportBySea { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportBySea2? TransportBySea { get; init; } 
    #else
    public TransportBySea2? TransportBySea { get; set; } 
    #endif
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_U7fnp9p-Ed-ak6NoX_4Aeg_-1683750967")]
    [DisplayName("Transport By Road")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByRoad")]
    #endif
    [IsoXmlTag("TrnsprtByRoad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRoad2? TransportByRoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRoad2? TransportByRoad { get; init; } 
    #else
    public TransportByRoad2? TransportByRoad { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("_U7oxkNp-Ed-ak6NoX_4Aeg_-1621872359")]
    [DisplayName("Transport By Rail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtByRail")]
    #endif
    [IsoXmlTag("TrnsprtByRail")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportByRail2? TransportByRail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportByRail2? TransportByRail { get; init; } 
    #else
    public TransportByRail2? TransportByRail { get; set; } 
    #endif
    
    
    #nullable disable
    
}
