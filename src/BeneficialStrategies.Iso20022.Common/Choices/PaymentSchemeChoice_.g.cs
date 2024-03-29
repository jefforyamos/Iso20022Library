﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentSchemeChoice.  ISO2002 ID# _QHyBDtp-Ed-ak6NoX_4Aeg_-1186600108.
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
    /// Pre-agreed offering between clearing agents, or the channel through which the payment instruction is to be processed. This payment scheme can point to a specific rulebook governing the rules of clearing and settlement between two parties.
    /// </summary>
    [KnownType(typeof(PaymentSchemeChoice.Code))]
    [KnownType(typeof(PaymentSchemeChoice.ProprietaryInformation))]
    [IsoId("_QHyBDtp-Ed-ak6NoX_4Aeg_-1186600108")]
    [DisplayName("Payment Scheme Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentSchemeChoice_
    #else
    public abstract partial class PaymentSchemeChoice_
    #endif
    {
    }
}
