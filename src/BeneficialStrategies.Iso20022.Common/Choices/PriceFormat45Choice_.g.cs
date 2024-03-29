﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat45Choice.  ISO2002 ID# _c9r6Q0EJEeWVgfuHGaKtRQ.
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
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat45Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat45Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat45Choice.NotSpecifiedPrice))]
    [IsoId("_c9r6Q0EJEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat45Choice_
    #else
    public abstract partial class PriceFormat45Choice_
    #endif
    {
    }
}
