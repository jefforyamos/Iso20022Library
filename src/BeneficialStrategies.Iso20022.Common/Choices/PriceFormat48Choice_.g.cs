﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat48Choice.  ISO2002 ID# _puBHSUELEeWVgfuHGaKtRQ.
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
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat48Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat48Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat48Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat48Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat48Choice.IndexPoints))]
    [IsoId("_puBHSUELEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 48 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat48Choice_
    #else
    public abstract partial class PriceFormat48Choice_
    #endif
    {
    }
}
