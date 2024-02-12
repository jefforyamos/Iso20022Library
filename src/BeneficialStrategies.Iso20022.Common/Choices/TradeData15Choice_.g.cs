﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeData15Choice.  ISO2002 ID# _30uHkf_qEemm3skPVSMJQg.
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
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData15Choice.DataSetAction))]
    [KnownType(typeof(TradeData15Choice.Report))]
    [IsoId("_30uHkf_qEemm3skPVSMJQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Data 15 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData15Choice_
    #else
    public abstract partial class TradeData15Choice_
    #endif
    {
    }
}
