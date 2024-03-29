﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus62Choice.  ISO2002 ID# _6d7vh5NLEeWGlc8L7oPDIg.
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
    [KnownType(typeof(ProcessingStatus62Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus62Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus62Choice.Repair))]
    [KnownType(typeof(ProcessingStatus62Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus62Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus62Choice.CancellationRequested))]
    [IsoId("_6d7vh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 62 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus62Choice_
    #else
    public abstract partial class ProcessingStatus62Choice_
    #endif
    {
    }
}
