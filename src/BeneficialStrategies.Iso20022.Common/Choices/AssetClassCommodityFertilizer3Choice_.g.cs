﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityFertilizer3Choice.  ISO2002 ID# _K19uYbv7EeiLRYqS-r-R-A.
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
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Ammonia))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.DiammoniumPhosphate))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Potash))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Sulphur))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Urea))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.UreaAndAmmoniumNitrate))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Other))]
    [IsoId("_K19uYbv7EeiLRYqS-r-R-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Asset Class Commodity Fertilizer 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityFertilizer3Choice_
    #else
    public abstract partial class AssetClassCommodityFertilizer3Choice_
    #endif
    {
    }
}
