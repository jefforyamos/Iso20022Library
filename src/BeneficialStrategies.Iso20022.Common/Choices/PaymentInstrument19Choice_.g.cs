﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentInstrument19Choice.  ISO2002 ID# _-J8xYSC1EeWJd9HF2tO7BA.
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
    /// Choice of payment instruments.
    /// </summary>
    [KnownType(typeof(PaymentInstrument19Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument19Choice.BankersDraftDetails))]
    [IsoId("_-J8xYSC1EeWJd9HF2tO7BA")]
    [DisplayName("Payment Instrument 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument19Choice_
    #else
    public abstract partial class PaymentInstrument19Choice_
    #endif
    {
    }
}
