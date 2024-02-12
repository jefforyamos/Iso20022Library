﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reason12Choice.  ISO2002 ID# _CekpyyRhEeO8sskhVI3IDA.
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
    [KnownType(typeof(Reason12Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason12Choice.CancellationReason))]
    [KnownType(typeof(Reason12Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason12Choice.GeneratedReason))]
    [KnownType(typeof(Reason12Choice.DeniedReason))]
    [KnownType(typeof(Reason12Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason12Choice.PendingReason))]
    [KnownType(typeof(Reason12Choice.FailingReason))]
    [KnownType(typeof(Reason12Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason12Choice.RejectionReason))]
    [KnownType(typeof(Reason12Choice.RepairReason))]
    [KnownType(typeof(Reason12Choice.PendingModificationReason))]
    [KnownType(typeof(Reason12Choice.UnmatchedReason))]
    [IsoId("_CekpyyRhEeO8sskhVI3IDA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason 12 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reason12Choice_
    #else
    public abstract partial class Reason12Choice_
    #endif
    {
    }
}
