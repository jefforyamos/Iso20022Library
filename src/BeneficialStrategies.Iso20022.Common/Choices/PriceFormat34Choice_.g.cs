﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat34Choice.  ISO2002 ID# _mVizRyXxEeO4bIO_HtGo9Q.
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
    [KnownType(typeof(PriceFormat34Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat34Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat34Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat34Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat34Choice.IndexPoints))]
    [IsoId("_mVizRyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat34Choice_
    #else
    public abstract partial class PriceFormat34Choice_
    #endif
    {
    }
}
