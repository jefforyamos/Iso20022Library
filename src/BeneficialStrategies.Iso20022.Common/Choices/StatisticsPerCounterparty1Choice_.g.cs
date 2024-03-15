﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatisticsPerCounterparty1Choice.  ISO2002 ID# _98o1tEwVEeqwfMIOLcNxbw.
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
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty1Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty1Choice.Report))]
    [IsoId("_98o1tEwVEeqwfMIOLcNxbw")]
    [DisplayName("Statistics Per Counterparty 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatisticsPerCounterparty1Choice_
    #else
    public abstract partial class StatisticsPerCounterparty1Choice_
    #endif
    {
    }
}
