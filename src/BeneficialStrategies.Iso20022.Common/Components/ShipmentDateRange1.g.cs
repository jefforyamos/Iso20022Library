﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ShipmentDateRange1.  ISO2002 ID# _Sp5_gtp-Ed-ak6NoX_4Aeg_-1649364101.
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
/// Specifies an earliest shipment date and a latest shipment date.
/// </summary>
[IsoId("_Sp5_gtp-Ed-ak6NoX_4Aeg_-1649364101")]
[DisplayName("Shipment Date Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShipmentDateRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Earliest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_Sp5_g9p-Ed-ak6NoX_4Aeg_-1349221863")]
    [DisplayName("Earliest Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstShipmntDt")]
    #endif
    [IsoXmlTag("EarlstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EarliestShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EarliestShipmentDate { get; init; } 
    #else
    public System.DateOnly? EarliestShipmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Latest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_Sp5_hNp-Ed-ak6NoX_4Aeg_-1302121318")]
    [DisplayName("Latest Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatstShipmntDt")]
    #endif
    [IsoXmlTag("LatstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LatestShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LatestShipmentDate { get; init; } 
    #else
    public System.DateOnly? LatestShipmentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
