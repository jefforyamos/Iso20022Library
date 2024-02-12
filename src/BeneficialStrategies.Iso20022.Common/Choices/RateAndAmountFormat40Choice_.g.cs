﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat40Choice.  ISO2002 ID# __EcZkUEIEeWVgfuHGaKtRQ.
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
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat40Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat40Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat40Choice.RateTypeAndRate))]
    [IsoId("__EcZkUEIEeWVgfuHGaKtRQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate And Amount Format 40 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat40Choice_
    #else
    public abstract partial class RateAndAmountFormat40Choice_
    #endif
    {
    }
}
