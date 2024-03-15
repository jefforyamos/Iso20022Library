﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RatioFormat24Choice.  ISO2002 ID# _cti6epKQEeWHWpTQn1FFVg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Choice of format to express a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat24Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat24Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat24Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat24Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat24Choice.QuantityToAmount))]
    [IsoId("_cti6epKQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 24 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat24Choice_
    #else
    public abstract partial class RatioFormat24Choice_
    #endif
    {
    }
}
