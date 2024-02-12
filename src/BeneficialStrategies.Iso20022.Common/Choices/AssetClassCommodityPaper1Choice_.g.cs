﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityPaper1Choice.  ISO2002 ID# _0bsBIFrxEeWN79Bl6BUd3g.
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
    /// Defines commodity attributes of a derivative where the type is paper.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPaper1Choice.ContainerBoard))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.Newsprint))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.Pulp))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.RecoveredPaper))]
    [IsoId("_0bsBIFrxEeWN79Bl6BUd3g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Asset Class Commodity Paper 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityPaper1Choice_
    #else
    public abstract partial class AssetClassCommodityPaper1Choice_
    #endif
    {
    }
}
