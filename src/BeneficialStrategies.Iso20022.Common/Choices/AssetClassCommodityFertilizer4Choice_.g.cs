﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityFertilizer4Choice.  ISO2002 ID# _icwoUU8REe2PGo0mhYCh1g.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Defines commodity attributes of a derivative where the type is fertilizer.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Ammonia))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.DiammoniumPhosphate))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Potash))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Sulphur))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Urea))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.UreaAndAmmoniumNitrate))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Other))]
    [IsoId("_icwoUU8REe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Fertilizer 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityFertilizer4Choice_
    #else
    public abstract partial class AssetClassCommodityFertilizer4Choice_
    #endif
    {
    }
}
