﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeType3Choice.  ISO2002 ID# _AXK_VNokEeC60axPepSq7g_1036683849.
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
    /// Choice of format for the trade type.
    /// </summary>
    [KnownType(typeof(TradeType3Choice.Code))]
    [KnownType(typeof(TradeType3Choice.Proprietary))]
    [IsoId("_AXK_VNokEeC60axPepSq7g_1036683849")]
    [DisplayName("Trade Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeType3Choice_
    #else
    public abstract partial class TradeType3Choice_
    #endif
    {
    }
}
