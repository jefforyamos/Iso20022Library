﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus14Choice.  ISO2002 ID# _KXLkUfI4Ed-dOvqmSLSz5g.
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
    [KnownType(typeof(ProcessingStatus14Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus14Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus14Choice.Completed))]
    [KnownType(typeof(ProcessingStatus14Choice.Denied))]
    [KnownType(typeof(ProcessingStatus14Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus14Choice.Pending))]
    [IsoId("_KXLkUfI4Ed-dOvqmSLSz5g")]
    [DisplayName("Processing Status 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus14Choice_
    #else
    public abstract partial class ProcessingStatus14Choice_
    #endif
    {
    }
}
