﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionToPerform4Choice.  ISO2002 ID# _8rz5wU31Eey_VecAUE-C9Q.
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
    /// Content of the Batch Request message.
    /// </summary>
    [KnownType(typeof(TransactionToPerform4Choice.PaymentRequest))]
    [KnownType(typeof(TransactionToPerform4Choice.LoyaltyRequest))]
    [KnownType(typeof(TransactionToPerform4Choice.ReversalRequest))]
    [IsoId("_8rz5wU31Eey_VecAUE-C9Q")]
    [DisplayName("Transaction To Perform 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionToPerform4Choice_
    #else
    public abstract partial class TransactionToPerform4Choice_
    #endif
    {
    }
}
