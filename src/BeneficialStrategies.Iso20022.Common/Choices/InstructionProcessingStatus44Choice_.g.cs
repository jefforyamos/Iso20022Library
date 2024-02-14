﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus44Choice.  ISO2002 ID# _9FAl9x9QEeuFz_FaCzCLgQ.
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
    [KnownType(typeof(InstructionProcessingStatus44Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus44Choice.ProprietaryStatus))]
    [IsoId("_9FAl9x9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Processing Status 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus44Choice_
    #else
    public abstract partial class InstructionProcessingStatus44Choice_
    #endif
    {
    }
}
