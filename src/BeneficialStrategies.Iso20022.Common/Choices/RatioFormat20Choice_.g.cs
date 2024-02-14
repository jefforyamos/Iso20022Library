﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RatioFormat20Choice.  ISO2002 ID# _DHUNIUGNEeWqy4niLuXETA.
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
    [KnownType(typeof(RatioFormat20Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat20Choice.AmountToAmount))]
    [IsoId("_DHUNIUGNEeWqy4niLuXETA")]
    [DisplayName("Ratio Format 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat20Choice_
    #else
    public abstract partial class RatioFormat20Choice_
    #endif
    {
    }
}
