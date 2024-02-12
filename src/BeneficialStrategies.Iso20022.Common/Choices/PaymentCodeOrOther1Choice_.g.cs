﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentCodeOrOther1Choice.  ISO2002 ID# _ogNJwNP8EeK0PPbKncCqzA.
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
    /// Choice between a payment term in a coded or free format.
    /// </summary>
    [KnownType(typeof(PaymentCodeOrOther1Choice.PaymentCode))]
    [KnownType(typeof(PaymentCodeOrOther1Choice.PaymentDueDate))]
    [KnownType(typeof(PaymentCodeOrOther1Choice.OtherPaymentTerms))]
    [IsoId("_ogNJwNP8EeK0PPbKncCqzA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Code Or Other 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentCodeOrOther1Choice_
    #else
    public abstract partial class PaymentCodeOrOther1Choice_
    #endif
    {
    }
}
