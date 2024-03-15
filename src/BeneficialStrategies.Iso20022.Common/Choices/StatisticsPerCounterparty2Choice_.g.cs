﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatisticsPerCounterparty2Choice.  ISO2002 ID# _85s8k0wWEeqwfMIOLcNxbw.
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
    [KnownType(typeof(StatisticsPerCounterparty2Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty2Choice.Report))]
    [IsoId("_85s8k0wWEeqwfMIOLcNxbw")]
    [DisplayName("Statistics Per Counterparty 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatisticsPerCounterparty2Choice_
    #else
    public abstract partial class StatisticsPerCounterparty2Choice_
    #endif
    {
    }
}
