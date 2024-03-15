﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat33Choice.  ISO2002 ID# _r15aZSXtEeO4bIO_HtGo9Q.
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
    [KnownType(typeof(PriceFormat33Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat33Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat33Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat33Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat33Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat33Choice.IndexPoints))]
    [IsoId("_r15aZSXtEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat33Choice_
    #else
    public abstract partial class PriceFormat33Choice_
    #endif
    {
    }
}
