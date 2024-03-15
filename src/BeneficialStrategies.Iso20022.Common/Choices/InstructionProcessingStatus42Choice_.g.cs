﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus42Choice.  ISO2002 ID# _7KKTcQpJEeup4r-PFG2T5Q.
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
    /// Choice of formats for an instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus42Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.ModificationRequested))]
    [IsoId("_7KKTcQpJEeup4r-PFG2T5Q")]
    [DisplayName("Instruction Processing Status 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus42Choice_
    #else
    public abstract partial class InstructionProcessingStatus42Choice_
    #endif
    {
    }
}
