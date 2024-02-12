﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus10Choice.  ISO2002 ID# _4BGdO_8dEeCrw_OT0uBMXQ.
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
    [KnownType(typeof(InstructionProcessingStatus10Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.ModificationRequested))]
    [IsoId("_4BGdO_8dEeCrw_OT0uBMXQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Processing Status 10 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus10Choice_
    #else
    public abstract partial class InstructionProcessingStatus10Choice_
    #endif
    {
    }
}
