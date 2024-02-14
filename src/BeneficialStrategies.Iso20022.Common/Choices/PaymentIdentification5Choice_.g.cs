﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentIdentification5Choice.  ISO2002 ID# _UhbRcZlQEee-Zps0fZQaFQ.
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
    /// Choice between ways of identifying a payment instruction by its references and business identification.
    /// </summary>
    [KnownType(typeof(PaymentIdentification5Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification5Choice.ProprietaryIdentification))]
    [IsoId("_UhbRcZlQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Identification 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentIdentification5Choice_
    #else
    public abstract partial class PaymentIdentification5Choice_
    #endif
    {
    }
}
