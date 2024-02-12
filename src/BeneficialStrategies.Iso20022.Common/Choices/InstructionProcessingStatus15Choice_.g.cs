﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus15Choice.  ISO2002 ID# _Rmr4ESdxEeOXAt_43VmZGw.
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
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus15Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus15Choice.ProprietaryStatus))]
    [IsoId("_Rmr4ESdxEeOXAt_43VmZGw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Processing Status 15 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus15Choice_
    #else
    public abstract partial class InstructionProcessingStatus15Choice_
    #endif
    {
    }
}
