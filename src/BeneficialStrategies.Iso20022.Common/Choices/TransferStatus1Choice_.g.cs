﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransferStatus1Choice.  ISO2002 ID# _-S3TkRwjEeOIveEnnb_1-A.
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
    /// Choice of statuses for the status of the transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus1Choice.Status))]
    [KnownType(typeof(TransferStatus1Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus1Choice.Unmatched))]
    [KnownType(typeof(TransferStatus1Choice.InRepair))]
    [KnownType(typeof(TransferStatus1Choice.Rejected))]
    [KnownType(typeof(TransferStatus1Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus1Choice.Cancelled))]
    [KnownType(typeof(TransferStatus1Choice.Reversed))]
    [KnownType(typeof(TransferStatus1Choice.CancellationPending))]
    [IsoId("_-S3TkRwjEeOIveEnnb_1-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Status 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferStatus1Choice_
    #else
    public abstract partial class TransferStatus1Choice_
    #endif
    {
    }
}
