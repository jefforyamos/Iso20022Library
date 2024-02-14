﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionCancellationRequestStatus14Choice.  ISO2002 ID# _peWYkzi7Eeydid5dcNPKvg.
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
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.ProprietaryStatus))]
    [IsoId("_peWYkzi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Cancellation Request Status 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus14Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus14Choice_
    #endif
    {
    }
}
