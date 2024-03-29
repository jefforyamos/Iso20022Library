﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionCancellationRequestStatus10Choice.  ISO2002 ID# _ce-5q5KQEeWHWpTQn1FFVg.
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
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.ProprietaryStatus))]
    [IsoId("_ce-5q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Cancellation Request Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus10Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus10Choice_
    #endif
    {
    }
}
