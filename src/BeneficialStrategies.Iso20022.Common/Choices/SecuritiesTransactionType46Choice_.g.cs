﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionType46Choice.  ISO2002 ID# _GajacdYPEeiHVOfMzoKxnA.
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
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType46Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType46Choice.Proprietary))]
    [IsoId("_GajacdYPEeiHVOfMzoKxnA")]
    [DisplayName("Securities Transaction Type 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType46Choice_
    #else
    public abstract partial class SecuritiesTransactionType46Choice_
    #endif
    {
    }
}
