﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentInstrument6Choice.  ISO2002 ID# _VKiwQNp-Ed-ak6NoX_4Aeg_-620434673.
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
    /// Choice between types of payment instrument, ie, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    [KnownType(typeof(PaymentInstrument6Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument6Choice.AccountDetails))]
    [IsoId("_VKiwQNp-Ed-ak6NoX_4Aeg_-620434673")]
    [DisplayName("Payment Instrument 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument6Choice_
    #else
    public abstract partial class PaymentInstrument6Choice_
    #endif
    {
    }
}
