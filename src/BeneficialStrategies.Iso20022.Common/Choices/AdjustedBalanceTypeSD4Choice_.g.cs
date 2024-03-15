﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdjustedBalanceTypeSD4Choice.  ISO2002 ID# _RWpyEcSTEeeRJJtE9TSlkw.
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
    /// Choice of balance types to provide transaction details.
    /// </summary>
    [KnownType(typeof(AdjustedBalanceTypeSD4Choice.StockLoan))]
    [KnownType(typeof(AdjustedBalanceTypeSD4Choice.Repo))]
    [IsoId("_RWpyEcSTEeeRJJtE9TSlkw")]
    [DisplayName("Adjusted Balance Type SD 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdjustedBalanceTypeSD4Choice_
    #else
    public abstract partial class AdjustedBalanceTypeSD4Choice_
    #endif
    {
    }
}
