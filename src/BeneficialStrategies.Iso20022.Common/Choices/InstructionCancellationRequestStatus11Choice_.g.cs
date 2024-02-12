﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionCancellationRequestStatus11Choice.  ISO2002 ID# _1OEe8YluEeavwKddCbm3hg.
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
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.ProprietaryStatus))]
    [IsoId("_1OEe8YluEeavwKddCbm3hg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Cancellation Request Status 11 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus11Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus11Choice_
    #endif
    {
    }
}
