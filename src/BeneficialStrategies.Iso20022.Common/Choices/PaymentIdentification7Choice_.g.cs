﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentIdentification7Choice.  ISO2002 ID# _5F42wAKxEe2rHs6fbn9-0A.
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
    [KnownType(typeof(PaymentIdentification7Choice.TransactionIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.UETR))]
    [KnownType(typeof(PaymentIdentification7Choice.QueueIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.LongBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.ShortBusinessIdentification))]
    [KnownType(typeof(PaymentIdentification7Choice.ProprietaryIdentification))]
    [IsoId("_5F42wAKxEe2rHs6fbn9-0A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Identification 7 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentIdentification7Choice_
    #else
    public abstract partial class PaymentIdentification7Choice_
    #endif
    {
    }
}
