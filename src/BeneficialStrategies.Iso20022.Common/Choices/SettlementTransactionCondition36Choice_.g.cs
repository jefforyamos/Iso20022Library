﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementTransactionCondition36Choice.  ISO2002 ID# _lfXiHSAaEeu4a6pNulzZ4Q.
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
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition36Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition36Choice.Proprietary))]
    [IsoId("_lfXiHSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Transaction Condition 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTransactionCondition36Choice_
    #else
    public abstract partial class SettlementTransactionCondition36Choice_
    #endif
    {
    }
}
