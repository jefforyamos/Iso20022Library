﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionType2Choice.  ISO2002 ID# _SyV7QQf_EeSaceXTzyiZRg.
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
    /// Choice of formats for the transaction type.
    /// </summary>
    [KnownType(typeof(TransactionType2Choice.Type))]
    [KnownType(typeof(TransactionType2Choice.Proprietary))]
    [IsoId("_SyV7QQf_EeSaceXTzyiZRg")]
    [DisplayName("Transaction Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionType2Choice_
    #else
    public abstract partial class TransactionType2Choice_
    #endif
    {
    }
}
