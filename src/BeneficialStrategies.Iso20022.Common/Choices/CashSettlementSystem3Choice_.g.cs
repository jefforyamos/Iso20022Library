﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CashSettlementSystem3Choice.  ISO2002 ID# _Aav3xNokEeC60axPepSq7g_1739194464.
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
    /// Choice of format for the cash settlement system.
    /// </summary>
    [KnownType(typeof(CashSettlementSystem3Choice.Code))]
    [KnownType(typeof(CashSettlementSystem3Choice.Proprietary))]
    [IsoId("_Aav3xNokEeC60axPepSq7g_1739194464")]
    [DisplayName("Cash Settlement System 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashSettlementSystem3Choice_
    #else
    public abstract partial class CashSettlementSystem3Choice_
    #endif
    {
    }
}
