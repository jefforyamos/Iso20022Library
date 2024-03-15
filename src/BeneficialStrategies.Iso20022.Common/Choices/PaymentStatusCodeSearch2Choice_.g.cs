﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentStatusCodeSearch2Choice.  ISO2002 ID# _RGEOMNp-Ed-ak6NoX_4Aeg_396814061.
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
    /// Choice between a list of pending statuses, final statuses or all statuses.
    /// </summary>
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.PendingStatus))]
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.FinalStatus))]
    [KnownType(typeof(PaymentStatusCodeSearch2Choice.PendingAndFinalStatus))]
    [IsoId("_RGEOMNp-Ed-ak6NoX_4Aeg_396814061")]
    [DisplayName("Payment Status Code Search 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentStatusCodeSearch2Choice_
    #else
    public abstract partial class PaymentStatusCodeSearch2Choice_
    #endif
    {
    }
}
