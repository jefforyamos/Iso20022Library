﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus45Choice.  ISO2002 ID# _waWtlSAeEeuyDZ-ukt4YRg.
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
    [KnownType(typeof(InstructionProcessingStatus45Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.ModificationRequested))]
    [IsoId("_waWtlSAeEeuyDZ-ukt4YRg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Processing Status 45 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus45Choice_
    #else
    public abstract partial class InstructionProcessingStatus45Choice_
    #endif
    {
    }
}
