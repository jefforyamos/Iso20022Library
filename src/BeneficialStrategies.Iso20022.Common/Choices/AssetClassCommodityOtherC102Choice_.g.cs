﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityOtherC102Choice.  ISO2002 ID# _lTiEcXvyEeanCNPcMT7sSg.
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
    /// Defines commodity attributes of a derivative where the type is other C10.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityOtherC102Choice.Deliverable))]
    [KnownType(typeof(AssetClassCommodityOtherC102Choice.NonDeliverable))]
    [IsoId("_lTiEcXvyEeanCNPcMT7sSg")]
    [DisplayName("Asset Class Commodity Other C 102 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityOtherC102Choice_
    #else
    public abstract partial class AssetClassCommodityOtherC102Choice_
    #endif
    {
    }
}
