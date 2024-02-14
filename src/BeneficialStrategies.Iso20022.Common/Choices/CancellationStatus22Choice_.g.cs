﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationStatus22Choice.  ISO2002 ID# _kZs-EEgsEeaD2L_hzZaE0w.
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
    /// Status is cancelled.
    /// </summary>
    [KnownType(typeof(CancellationStatus22Choice.Status))]
    [KnownType(typeof(CancellationStatus22Choice.Rejected))]
    [IsoId("_kZs-EEgsEeaD2L_hzZaE0w")]
    [DisplayName("Cancellation Status 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatus22Choice_
    #else
    public abstract partial class CancellationStatus22Choice_
    #endif
    {
    }
}
