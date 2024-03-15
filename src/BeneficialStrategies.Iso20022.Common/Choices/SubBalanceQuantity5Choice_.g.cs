﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SubBalanceQuantity5Choice.  ISO2002 ID# _01_3kYjvEeONZKAAW4pOaQ.
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
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity5Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity5Choice.Proprietary))]
    [IsoId("_01_3kYjvEeONZKAAW4pOaQ")]
    [DisplayName("Sub Balance Quantity 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity5Choice_
    #else
    public abstract partial class SubBalanceQuantity5Choice_
    #endif
    {
    }
}
