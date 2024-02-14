﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingReason31Choice.  ISO2002 ID# _qpuxgTw9EeW3QqUkIQtIUA.
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
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason31Choice.Code))]
    [KnownType(typeof(PendingReason31Choice.Proprietary))]
    [IsoId("_qpuxgTw9EeW3QqUkIQtIUA")]
    [DisplayName("Pending Reason 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason31Choice_
    #else
    public abstract partial class PendingReason31Choice_
    #endif
    {
    }
}
