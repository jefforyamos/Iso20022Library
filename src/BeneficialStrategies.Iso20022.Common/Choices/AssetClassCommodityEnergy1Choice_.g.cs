﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityEnergy1Choice.  ISO2002 ID# _pBoTZg2nEeW72qLtWESimw.
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
    /// Defines commodity attributes of a derivative where the type is energy.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Electricity))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.NaturalGas))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Oil))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Coal))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.InterEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.RenewableEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.LightEnd))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Distillates))]
    [IsoId("_pBoTZg2nEeW72qLtWESimw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Asset Class Commodity Energy 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityEnergy1Choice_
    #else
    public abstract partial class AssetClassCommodityEnergy1Choice_
    #endif
    {
    }
}
