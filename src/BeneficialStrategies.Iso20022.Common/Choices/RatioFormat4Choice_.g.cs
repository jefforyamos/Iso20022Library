﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RatioFormat4Choice.  ISO2002 ID# _Q1h31dp-Ed-ak6NoX_4Aeg_544072927.
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
    [KnownType(typeof(RatioFormat4Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat4Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat4Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat4Choice.QuantityToAmount))]
    [IsoId("_Q1h31dp-Ed-ak6NoX_4Aeg_544072927")]
    [DisplayName("Ratio Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat4Choice_
    #else
    public abstract partial class RatioFormat4Choice_
    #endif
    {
    }
}
