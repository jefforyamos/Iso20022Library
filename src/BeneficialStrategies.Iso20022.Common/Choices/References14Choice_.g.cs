﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References14Choice.  ISO2002 ID# _u7dqIeDgEd-udr336SN7mQ.
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
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References14Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References14Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References14Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References14Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References14Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References14Choice.PoolIdentification))]
    [KnownType(typeof(References14Choice.OtherTransactionIdentification))]
    [IsoId("_u7dqIeDgEd-udr336SN7mQ")]
    [DisplayName("References 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References14Choice_
    #else
    public abstract partial class References14Choice_
    #endif
    {
    }
}
