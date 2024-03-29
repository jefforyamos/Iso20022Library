﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BenchmarkCurveName4Choice.  ISO2002 ID# _1oxvgQnVEeWa7rBfPECYsw.
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
    /// Choice of format for benchmark curve name.
    /// </summary>
    [KnownType(typeof(BenchmarkCurveName4Choice.ISIN))]
    [KnownType(typeof(BenchmarkCurveName4Choice.Index))]
    [KnownType(typeof(BenchmarkCurveName4Choice.Name))]
    [IsoId("_1oxvgQnVEeWa7rBfPECYsw")]
    [DisplayName("Benchmark Curve Name 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BenchmarkCurveName4Choice_
    #else
    public abstract partial class BenchmarkCurveName4Choice_
    #endif
    {
    }
}
