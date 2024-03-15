﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat66Choice.  ISO2002 ID# _O9l7ZRuyEeyhRdHRjakS2w.
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
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat66Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat66Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat66Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat66Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat66Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat66Choice.IndexPoints))]
    [IsoId("_O9l7ZRuyEeyhRdHRjakS2w")]
    [DisplayName("Price Format 66 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat66Choice_
    #else
    public abstract partial class PriceFormat66Choice_
    #endif
    {
    }
}
