﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementInstructionReason1Choice.  ISO2002 ID# _YtrTQCCsEeWJd9HF2tO7BA.
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
    /// Choice of formats for the settlement instruction reason.
    /// </summary>
    [KnownType(typeof(SettlementInstructionReason1Choice.Code))]
    [KnownType(typeof(SettlementInstructionReason1Choice.Proprietary))]
    [IsoId("_YtrTQCCsEeWJd9HF2tO7BA")]
    [DisplayName("Settlement Instruction Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementInstructionReason1Choice_
    #else
    public abstract partial class SettlementInstructionReason1Choice_
    #endif
    {
    }
}
