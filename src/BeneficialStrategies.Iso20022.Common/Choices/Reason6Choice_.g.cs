﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reason6Choice.  ISO2002 ID# _is3dwUAAEeCaq78Ig8ATcA.
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
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason6Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason6Choice.CancellationReason))]
    [KnownType(typeof(Reason6Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason6Choice.GeneratedReason))]
    [KnownType(typeof(Reason6Choice.DeniedReason))]
    [KnownType(typeof(Reason6Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason6Choice.PendingReason))]
    [KnownType(typeof(Reason6Choice.FailingReason))]
    [KnownType(typeof(Reason6Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason6Choice.RejectionReason))]
    [KnownType(typeof(Reason6Choice.RepairReason))]
    [KnownType(typeof(Reason6Choice.PendingModificationReason))]
    [KnownType(typeof(Reason6Choice.UnmatchedReason))]
    [IsoId("_is3dwUAAEeCaq78Ig8ATcA")]
    [DisplayName("Reason 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reason6Choice_
    #else
    public abstract partial class Reason6Choice_
    #endif
    {
    }
}
