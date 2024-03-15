﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus23Choice.  ISO2002 ID# _tTjyYf7sEeCvPoRGOxRobQ.
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
    [KnownType(typeof(ProcessingStatus23Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus23Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus23Choice.Repair))]
    [KnownType(typeof(ProcessingStatus23Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus23Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus23Choice.CancellationRequested))]
    [IsoId("_tTjyYf7sEeCvPoRGOxRobQ")]
    [DisplayName("Processing Status 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus23Choice_
    #else
    public abstract partial class ProcessingStatus23Choice_
    #endif
    {
    }
}
