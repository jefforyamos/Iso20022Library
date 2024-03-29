﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentAttributes4Choice.  ISO2002 ID# _F042MZ3CEeuwmdq0KtnICg.
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
    /// Specifies the attributes of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentAttributes4Choice.Identification))]
    [KnownType(typeof(FinancialInstrumentAttributes4Choice.Other))]
    [IsoId("_F042MZ3CEeuwmdq0KtnICg")]
    [DisplayName("Financial Instrument Attributes 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentAttributes4Choice_
    #else
    public abstract partial class FinancialInstrumentAttributes4Choice_
    #endif
    {
    }
}
