﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LotteryTypeFormat1Choice.  ISO2002 ID# _Q3BFmtp-Ed-ak6NoX_4Aeg_-29945278.
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
    /// Choice between a standard code or proprietary code to specify the type of lottery.
    /// </summary>
    [KnownType(typeof(LotteryTypeFormat1Choice.Code))]
    [KnownType(typeof(LotteryTypeFormat1Choice.Proprietary))]
    [IsoId("_Q3BFmtp-Ed-ak6NoX_4Aeg_-29945278")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lottery Type Format 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LotteryTypeFormat1Choice_
    #else
    public abstract partial class LotteryTypeFormat1Choice_
    #endif
    {
    }
}
