﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType33Choice.  ISO2002 ID# _0ESe0UEIEeWVgfuHGaKtRQ.
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
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType33Choice.Code))]
    [KnownType(typeof(RateType33Choice.Proprietary))]
    [IsoId("_0ESe0UEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType33Choice_
    #else
    public abstract partial class RateType33Choice_
    #endif
    {
    }
}
