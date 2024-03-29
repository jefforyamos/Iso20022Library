﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus22Choice.  ISO2002 ID# _hEW6STnuEeWfSKvvZlhRKg.
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
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus22Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus22Choice.ModificationRequested))]
    [IsoId("_hEW6STnuEeWfSKvvZlhRKg")]
    [DisplayName("Instruction Processing Status 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus22Choice_
    #else
    public abstract partial class InstructionProcessingStatus22Choice_
    #endif
    {
    }
}
