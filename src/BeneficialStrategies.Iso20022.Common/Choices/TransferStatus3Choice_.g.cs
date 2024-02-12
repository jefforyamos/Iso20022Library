﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransferStatus3Choice.  ISO2002 ID# _aORxAVNUEeijdq8ilaxyOA.
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
    /// Choice of statuses for the status of a transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus3Choice.Status))]
    [KnownType(typeof(TransferStatus3Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus3Choice.Unmatched))]
    [KnownType(typeof(TransferStatus3Choice.InRepair))]
    [KnownType(typeof(TransferStatus3Choice.Rejected))]
    [KnownType(typeof(TransferStatus3Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus3Choice.Cancelled))]
    [KnownType(typeof(TransferStatus3Choice.Reversed))]
    [KnownType(typeof(TransferStatus3Choice.CancellationPending))]
    [IsoId("_aORxAVNUEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Status 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferStatus3Choice_
    #else
    public abstract partial class TransferStatus3Choice_
    #endif
    {
    }
}
