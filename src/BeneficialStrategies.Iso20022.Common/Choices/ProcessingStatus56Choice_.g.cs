﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus56Choice.  ISO2002 ID# _c72FMTt5EeW638lNyHKv7A.
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
    /// Provides the status of a transaction.
    /// </summary>
    [KnownType(typeof(ProcessingStatus56Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus56Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus56Choice.Accepted))]
    [IsoId("_c72FMTt5EeW638lNyHKv7A")]
    [DisplayName("Processing Status 56 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus56Choice_
    #else
    public abstract partial class ProcessingStatus56Choice_
    #endif
    {
    }
}
