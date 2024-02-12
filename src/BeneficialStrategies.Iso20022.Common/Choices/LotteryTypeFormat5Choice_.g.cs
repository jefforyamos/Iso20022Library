﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LotteryTypeFormat5Choice.  ISO2002 ID# _cdS3gZKQEeWHWpTQn1FFVg.
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
    [KnownType(typeof(LotteryTypeFormat5Choice.Code))]
    [KnownType(typeof(LotteryTypeFormat5Choice.Proprietary))]
    [IsoId("_cdS3gZKQEeWHWpTQn1FFVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lottery Type Format 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LotteryTypeFormat5Choice_
    #else
    public abstract partial class LotteryTypeFormat5Choice_
    #endif
    {
    }
}
