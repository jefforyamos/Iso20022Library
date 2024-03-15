﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatisticsPerCounterparty17Choice.  ISO2002 ID# _x7sJF1yGEe24CqbZJK5XxA.
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
    [KnownType(typeof(StatisticsPerCounterparty17Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty17Choice.Report))]
    [IsoId("_x7sJF1yGEe24CqbZJK5XxA")]
    [DisplayName("Statistics Per Counterparty 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatisticsPerCounterparty17Choice_
    #else
    public abstract partial class StatisticsPerCounterparty17Choice_
    #endif
    {
    }
}
