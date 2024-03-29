﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionTypeStatus2Choice.  ISO2002 ID# _q8cZMV6uEeSyc4g_pm5hbw.
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
    /// Choice of instruction type status.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus2Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus2Choice.CancellationStatus))]
    [IsoId("_q8cZMV6uEeSyc4g_pm5hbw")]
    [DisplayName("Instruction Type Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionTypeStatus2Choice_
    #else
    public abstract partial class InstructionTypeStatus2Choice_
    #endif
    {
    }
}
