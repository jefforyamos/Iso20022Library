﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceType1Choice.  ISO2002 ID# _RdnLhdp-Ed-ak6NoX_4Aeg_549795611.
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
    /// Choice of price type.
    /// </summary>
    [KnownType(typeof(PriceType1Choice.Market))]
    [KnownType(typeof(PriceType1Choice.Indicative))]
    [IsoId("_RdnLhdp-Ed-ak6NoX_4Aeg_549795611")]
    [DisplayName("Price Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceType1Choice_
    #else
    public abstract partial class PriceType1Choice_
    #endif
    {
    }
}
