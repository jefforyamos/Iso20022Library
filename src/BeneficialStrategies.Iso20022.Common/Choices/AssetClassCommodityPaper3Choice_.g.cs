﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityPaper3Choice.  ISO2002 ID# __d2KIbv7EeiLRYqS-r-R-A.
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
    [KnownType(typeof(AssetClassCommodityPaper3Choice.ContainerBoard))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.Newsprint))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.Pulp))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.RecoveredPaper))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.Other))]
    [IsoId("__d2KIbv7EeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Paper 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityPaper3Choice_
    #else
    public abstract partial class AssetClassCommodityPaper3Choice_
    #endif
    {
    }
}
