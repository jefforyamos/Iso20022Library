﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus19Choice.  ISO2002 ID# __qPVMf4wEeClUvPNHKL9Zw.
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
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus19Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus19Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus19Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus19Choice.Repair))]
    [KnownType(typeof(ProcessingStatus19Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus19Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus19Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus19Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus19Choice.ModificationRequested))]
    [IsoId("__qPVMf4wEeClUvPNHKL9Zw")]
    [DisplayName("Processing Status 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus19Choice_
    #else
    public abstract partial class ProcessingStatus19Choice_
    #endif
    {
    }
}
