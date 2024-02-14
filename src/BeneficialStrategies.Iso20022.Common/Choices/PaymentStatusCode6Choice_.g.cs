﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentStatusCode6Choice.  ISO2002 ID# _pIXBKRbzEeOy-PlRuFSUzQ.
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
    /// Choice between a list of pending statuses or final statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCode6Choice.Pending))]
    [KnownType(typeof(PaymentStatusCode6Choice.Final))]
    [KnownType(typeof(PaymentStatusCode6Choice.RTGS))]
    [KnownType(typeof(PaymentStatusCode6Choice.Settlement))]
    [KnownType(typeof(PaymentStatusCode6Choice.Proprietary))]
    [IsoId("_pIXBKRbzEeOy-PlRuFSUzQ")]
    [DisplayName("Payment Status Code 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCode6Choice_
    #else
    public abstract partial class PaymentStatusCode6Choice_
    #endif
    {
    }
}
