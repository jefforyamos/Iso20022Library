﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateFormat8Choice.  ISO2002 ID# _VA1AzhLtEeKJ5uSjVyVvug.
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
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat8Choice.Rate))]
    [KnownType(typeof(RateFormat8Choice.Amount))]
    [KnownType(typeof(RateFormat8Choice.NotSpecifiedRate))]
    [IsoId("_VA1AzhLtEeKJ5uSjVyVvug")]
    [DisplayName("Rate Format 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat8Choice_
    #else
    public abstract partial class RateFormat8Choice_
    #endif
    {
    }
}
