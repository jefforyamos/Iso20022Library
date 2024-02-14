﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeReport31Choice.  ISO2002 ID# _oyOyxVosEe23K4GXSpBSeg.
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
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeReport31Choice.New))]
    [KnownType(typeof(TradeReport31Choice.MarginUpdate))]
    [KnownType(typeof(TradeReport31Choice.Error))]
    [KnownType(typeof(TradeReport31Choice.Correction))]
    [IsoId("_oyOyxVosEe23K4GXSpBSeg")]
    [DisplayName("Trade Report 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReport31Choice_
    #else
    public abstract partial class TradeReport31Choice_
    #endif
    {
    }
}
