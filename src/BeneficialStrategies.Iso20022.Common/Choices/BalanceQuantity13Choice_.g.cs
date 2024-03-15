﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceQuantity13Choice.  ISO2002 ID# _ieYh8Sp6EeyR9JrVGfaMKw.
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
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity13Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity13Choice.Proprietary))]
    [IsoId("_ieYh8Sp6EeyR9JrVGfaMKw")]
    [DisplayName("Balance Quantity 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceQuantity13Choice_
    #else
    public abstract partial class BalanceQuantity13Choice_
    #endif
    {
    }
}
