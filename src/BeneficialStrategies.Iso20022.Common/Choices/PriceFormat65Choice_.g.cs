﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat65Choice.  ISO2002 ID# _L_wROxuyEeyhRdHRjakS2w.
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
    [KnownType(typeof(PriceFormat65Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat65Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat65Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat65Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat65Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat65Choice.IndexPoints))]
    [IsoId("_L_wROxuyEeyhRdHRjakS2w")]
    [DisplayName("Price Format 65 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat65Choice_
    #else
    public abstract partial class PriceFormat65Choice_
    #endif
    {
    }
}
