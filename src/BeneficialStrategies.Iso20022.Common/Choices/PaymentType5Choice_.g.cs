﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentType5Choice.  ISO2002 ID# _nBzdgekAEemV35DUs8L82Q.
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
    /// Choice beween a payment type from a predefined list and a proprietary payment type.
    /// </summary>
    [KnownType(typeof(PaymentType5Choice.Type))]
    [KnownType(typeof(PaymentType5Choice.ProprietaryType))]
    [IsoId("_nBzdgekAEemV35DUs8L82Q")]
    [DisplayName("Payment Type 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentType5Choice_
    #else
    public abstract partial class PaymentType5Choice_
    #endif
    {
    }
}
