﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat32Choice.  ISO2002 ID# _4vHhsSXoEeO4bIO_HtGo9Q.
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
    [KnownType(typeof(PriceFormat32Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat32Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat32Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat32Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat32Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat32Choice.IndexPoints))]
    [IsoId("_4vHhsSXoEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat32Choice_
    #else
    public abstract partial class PriceFormat32Choice_
    #endif
    {
    }
}
