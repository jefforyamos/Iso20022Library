﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CardPaymentDataSetTransaction11Choice.  ISO2002 ID# _1rUJMXJCEe299ZbWCkdR_w.
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
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.TokenResponse))]
    [IsoId("_1rUJMXJCEe299ZbWCkdR_w")]
    [DisplayName("Card Payment Data Set Transaction 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction11Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction11Choice_
    #endif
    {
    }
}
