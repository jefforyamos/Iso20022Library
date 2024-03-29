﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionType34Choice.  ISO2002 ID# _zmv34ZwxEeazcsnODTksnQ.
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
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType34Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType34Choice.Proprietary))]
    [IsoId("_zmv34ZwxEeazcsnODTksnQ")]
    [DisplayName("Securities Transaction Type 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType34Choice_
    #else
    public abstract partial class SecuritiesTransactionType34Choice_
    #endif
    {
    }
}
