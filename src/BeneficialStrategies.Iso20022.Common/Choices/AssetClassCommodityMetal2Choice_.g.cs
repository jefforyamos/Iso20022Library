﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassCommodityMetal2Choice.  ISO2002 ID# _DnKNIU8REe2PGo0mhYCh1g.
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
    /// Defines commodity attributes of a derivative where the type is metal.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityMetal2Choice.NonPrecious))]
    [KnownType(typeof(AssetClassCommodityMetal2Choice.Precious))]
    [IsoId("_DnKNIU8REe2PGo0mhYCh1g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Asset Class Commodity Metal 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityMetal2Choice_
    #else
    public abstract partial class AssetClassCommodityMetal2Choice_
    #endif
    {
    }
}
