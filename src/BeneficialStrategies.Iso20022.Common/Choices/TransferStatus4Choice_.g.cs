﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransferStatus4Choice.  ISO2002 ID# _fTIFwZM5EemKz5EOjv82iQ.
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
    /// Choice of statuses for the status of a transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus4Choice.Status))]
    [KnownType(typeof(TransferStatus4Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus4Choice.Unmatched))]
    [KnownType(typeof(TransferStatus4Choice.InRepair))]
    [KnownType(typeof(TransferStatus4Choice.Rejected))]
    [KnownType(typeof(TransferStatus4Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus4Choice.Cancelled))]
    [KnownType(typeof(TransferStatus4Choice.Reversed))]
    [KnownType(typeof(TransferStatus4Choice.CancellationPending))]
    [IsoId("_fTIFwZM5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferStatus4Choice_
    #else
    public abstract partial class TransferStatus4Choice_
    #endif
    {
    }
}
