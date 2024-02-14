﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentInstrument9Choice.  ISO2002 ID# _VKshR9p-Ed-ak6NoX_4Aeg_852770854.
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
    [KnownType(typeof(PaymentInstrument9Choice.PaymentCardDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.CreditTransferDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.DirectDebitDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.ChequeDetails))]
    [KnownType(typeof(PaymentInstrument9Choice.AccountDetails))]
    [IsoId("_VKshR9p-Ed-ak6NoX_4Aeg_852770854")]
    [DisplayName("Payment Instrument 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentInstrument9Choice_
    #else
    public abstract partial class PaymentInstrument9Choice_
    #endif
    {
    }
}
