﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus33Choice.  ISO2002 ID# _IuIhmdB7EeihG9bKfarOOA.
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
    [KnownType(typeof(InstructionProcessingStatus33Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.ModificationRequested))]
    [IsoId("_IuIhmdB7EeihG9bKfarOOA")]
    [DisplayName("Instruction Processing Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus33Choice_
    #else
    public abstract partial class InstructionProcessingStatus33Choice_
    #endif
    {
    }
}
