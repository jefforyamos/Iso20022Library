﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MeetingCancellationReason1Choice.  ISO2002 ID# _RCWL0dp-Ed-ak6NoX_4Aeg_1417276542.
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
    /// Choice of meeting cancellation reason.
    /// </summary>
    [KnownType(typeof(MeetingCancellationReason1Choice.Code))]
    [KnownType(typeof(MeetingCancellationReason1Choice.Proprietary))]
    [IsoId("_RCWL0dp-Ed-ak6NoX_4Aeg_1417276542")]
    [DisplayName("Meeting Cancellation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MeetingCancellationReason1Choice_
    #else
    public abstract partial class MeetingCancellationReason1Choice_
    #endif
    {
    }
}
