﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionCancellationRequestStatus13Choice.  ISO2002 ID# _Vi6SERn0EeyroI8qKgB7Mg.
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
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.ProprietaryStatus))]
    [IsoId("_Vi6SERn0EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Cancellation Request Status 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus13Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus13Choice_
    #endif
    {
    }
}
