﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentStatusCode4Choice.  ISO2002 ID# _RZcdOtp-Ed-ak6NoX_4Aeg_1463454824.
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
    [KnownType(typeof(PaymentStatusCode4Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCode4Choice.FinalStatus))]
    [KnownType(typeof(PaymentStatusCode4Choice.ProprietaryStatus))]
    [IsoId("_RZcdOtp-Ed-ak6NoX_4Aeg_1463454824")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Status Code 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCode4Choice_
    #else
    public abstract partial class PaymentStatusCode4Choice_
    #endif
    {
    }
}
