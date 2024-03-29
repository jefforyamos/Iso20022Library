﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateFormat1Choice.  ISO2002 ID# _UPh5htp-Ed-ak6NoX_4Aeg_-1635558299.
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
    /// Choice of format to expressed a rate.
    /// </summary>
    [KnownType(typeof(RateFormat1Choice.Rate))]
    [KnownType(typeof(RateFormat1Choice.NotSpecifiedRate))]
    [IsoId("_UPh5htp-Ed-ak6NoX_4Aeg_-1635558299")]
    [DisplayName("Rate Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat1Choice_
    #else
    public abstract partial class RateFormat1Choice_
    #endif
    {
    }
}
