﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus4Choice.  ISO2002 ID# _UUTExtp-Ed-ak6NoX_4Aeg_-735060643.
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
    [KnownType(typeof(ProcessingStatus4Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus4Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus4Choice.Proprietary))]
    [IsoId("_UUTExtp-Ed-ak6NoX_4Aeg_-735060643")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Status 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus4Choice_
    #else
    public abstract partial class ProcessingStatus4Choice_
    #endif
    {
    }
}
