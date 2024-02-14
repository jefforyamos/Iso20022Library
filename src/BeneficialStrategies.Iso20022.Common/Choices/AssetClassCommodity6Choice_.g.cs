﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodity6Choice.  ISO2002 ID# _1anjQRZXEe2QNcZTDeoKnQ.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define commodity specific attributes of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassCommodity6Choice.Agricultural))]
    [KnownType(typeof(AssetClassCommodity6Choice.Energy))]
    [KnownType(typeof(AssetClassCommodity6Choice.Environmental))]
    [KnownType(typeof(AssetClassCommodity6Choice.Fertilizer))]
    [KnownType(typeof(AssetClassCommodity6Choice.Freight))]
    [KnownType(typeof(AssetClassCommodity6Choice.Index))]
    [KnownType(typeof(AssetClassCommodity6Choice.IndustrialProduct))]
    [KnownType(typeof(AssetClassCommodity6Choice.Inflation))]
    [KnownType(typeof(AssetClassCommodity6Choice.Metal))]
    [KnownType(typeof(AssetClassCommodity6Choice.MultiCommodityExotic))]
    [KnownType(typeof(AssetClassCommodity6Choice.OfficialEconomicStatistics))]
    [KnownType(typeof(AssetClassCommodity6Choice.Other))]
    [KnownType(typeof(AssetClassCommodity6Choice.OtherC10))]
    [KnownType(typeof(AssetClassCommodity6Choice.Paper))]
    [KnownType(typeof(AssetClassCommodity6Choice.Polypropylene))]
    [IsoId("_1anjQRZXEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodity6Choice_
    #else
    public abstract partial class AssetClassCommodity6Choice_
    #endif
    {
    }
}
