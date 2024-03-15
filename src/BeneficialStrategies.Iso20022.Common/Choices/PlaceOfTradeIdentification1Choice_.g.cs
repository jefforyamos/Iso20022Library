﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PlaceOfTradeIdentification1Choice.  ISO2002 ID# _TCWUu9p-Ed-ak6NoX_4Aeg_-2100921873.
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
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.Country))]
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.Exchange))]
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.Party))]
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.OverTheCounter))]
    [IsoId("_TCWUu9p-Ed-ak6NoX_4Aeg_-2100921873")]
    [DisplayName("Place Of Trade Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PlaceOfTradeIdentification1Choice_
    #else
    public abstract partial class PlaceOfTradeIdentification1Choice_
    #endif
    {
    }
}
