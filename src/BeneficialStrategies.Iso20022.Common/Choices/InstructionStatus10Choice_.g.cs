﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionStatus10Choice.  ISO2002 ID# _btxejfNfEeqRfth943bvEA.
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
    [KnownType(typeof(InstructionStatus10Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus10Choice.Rejected))]
    [KnownType(typeof(InstructionStatus10Choice.Pending))]
    [IsoId("_btxejfNfEeqRfth943bvEA")]
    [DisplayName("Instruction Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionStatus10Choice_
    #else
    public abstract partial class InstructionStatus10Choice_
    #endif
    {
    }
}
