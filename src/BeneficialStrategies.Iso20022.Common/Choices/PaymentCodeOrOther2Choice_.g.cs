﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentCodeOrOther2Choice.  ISO2002 ID# _RfD1sRVgEeOrY9qSHVspCA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    [KnownType(typeof(PaymentCodeOrOther2Choice.PaymentCode))]
    [KnownType(typeof(PaymentCodeOrOther2Choice.PaymentDueDate))]
    [KnownType(typeof(PaymentCodeOrOther2Choice.OtherPaymentTerms))]
    [IsoId("_RfD1sRVgEeOrY9qSHVspCA")]
    [DisplayName("Payment Code Or Other 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentCodeOrOther2Choice_
    #else
    public abstract partial class PaymentCodeOrOther2Choice_
    #endif
    {
    }
}
