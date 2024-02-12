﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RatioFormat19Choice.  ISO2002 ID# _7_6m0UEKEeWVgfuHGaKtRQ.
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
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat19Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat19Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat19Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat19Choice.QuantityToAmount))]
    [IsoId("_7_6m0UEKEeWVgfuHGaKtRQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ratio Format 19 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat19Choice_
    #else
    public abstract partial class RatioFormat19Choice_
    #endif
    {
    }
}
