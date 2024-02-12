﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus77Choice.  ISO2002 ID# _AYE5i_fZEeiNZp_PtLohLw.
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
    /// Choice of formats for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus77Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus77Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus77Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus77Choice.Repair))]
    [KnownType(typeof(ProcessingStatus77Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus77Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus77Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus77Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus77Choice.ModificationRequested))]
    [IsoId("_AYE5i_fZEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Status 77 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus77Choice_
    #else
    public abstract partial class ProcessingStatus77Choice_
    #endif
    {
    }
}
