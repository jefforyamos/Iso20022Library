﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus1Choice.  ISO2002 ID# _UVfXktp-Ed-ak6NoX_4Aeg_1256986454.
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
    [KnownType(typeof(ProcessingStatus1Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus1Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus1Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus1Choice.Repair))]
    [KnownType(typeof(ProcessingStatus1Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus1Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus1Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus1Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus1Choice.ModificationRequested))]
    [IsoId("_UVfXktp-Ed-ak6NoX_4Aeg_1256986454")]
    [DisplayName("Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus1Choice_
    #else
    public abstract partial class ProcessingStatus1Choice_
    #endif
    {
    }
}
