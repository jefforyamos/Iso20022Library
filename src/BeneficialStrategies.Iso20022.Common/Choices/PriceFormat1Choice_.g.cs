﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat1Choice.  ISO2002 ID# _QatkFdp-Ed-ak6NoX_4Aeg_-958538176.
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
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat1Choice.Amount))]
    [KnownType(typeof(PriceFormat1Choice.Rate))]
    [KnownType(typeof(PriceFormat1Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat1Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat1Choice.NotSpecified))]
    [IsoId("_QatkFdp-Ed-ak6NoX_4Aeg_-958538176")]
    [DisplayName("Price Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat1Choice_
    #else
    public abstract partial class PriceFormat1Choice_
    #endif
    {
    }
}
