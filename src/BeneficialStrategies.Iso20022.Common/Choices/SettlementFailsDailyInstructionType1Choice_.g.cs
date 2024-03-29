﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementFailsDailyInstructionType1Choice.  ISO2002 ID# _-9n1xTOkEeqX8uoQQ3KffQ.
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
    /// Specifies the details on the settlement fails split per instruction types or explicit no data report..
    /// </summary>
    [KnownType(typeof(SettlementFailsDailyInstructionType1Choice.DataSetAction))]
    [KnownType(typeof(SettlementFailsDailyInstructionType1Choice.Data))]
    [IsoId("_-9n1xTOkEeqX8uoQQ3KffQ")]
    [DisplayName("Settlement Fails Daily Instruction Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementFailsDailyInstructionType1Choice_
    #else
    public abstract partial class SettlementFailsDailyInstructionType1Choice_
    #endif
    {
    }
}
