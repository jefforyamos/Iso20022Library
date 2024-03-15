﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DailyFundTransfer1Choice.  ISO2002 ID# _mJGJgCc6Eea7avjfd7yDAA.
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
    /// Choice between time and event fund transfer.
    /// </summary>
    [KnownType(typeof(DailyFundTransfer1Choice.TransferTime))]
    [KnownType(typeof(DailyFundTransfer1Choice.TransferEvent))]
    [IsoId("_mJGJgCc6Eea7avjfd7yDAA")]
    [DisplayName("Daily Fund Transfer 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DailyFundTransfer1Choice_
    #else
    public abstract partial class DailyFundTransfer1Choice_
    #endif
    {
    }
}
