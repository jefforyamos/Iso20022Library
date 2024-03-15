﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionStatus8Choice.  ISO2002 ID# _8v5Era-nEemJ1NnLPsTFaw.
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
    /// Status applying globally to the instruction received.
    /// </summary>
    [KnownType(typeof(InstructionStatus8Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus8Choice.Rejected))]
    [KnownType(typeof(InstructionStatus8Choice.Pending))]
    [IsoId("_8v5Era-nEemJ1NnLPsTFaw")]
    [DisplayName("Instruction Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionStatus8Choice_
    #else
    public abstract partial class InstructionStatus8Choice_
    #endif
    {
    }
}
