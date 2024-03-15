﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References36Choice.  ISO2002 ID# _jx45V-5NEeCisYr99QEiWA_-1477565107.
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
    /// References of the original instruction for which an action has been requested.
    /// </summary>
    [KnownType(typeof(References36Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References36Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References36Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References36Choice.ProcessorTransactionIdentification))]
    [KnownType(typeof(References36Choice.PoolIdentification))]
    [KnownType(typeof(References36Choice.CorporateActionEventIdentification))]
    [IsoId("_jx45V-5NEeCisYr99QEiWA_-1477565107")]
    [DisplayName("References 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References36Choice_
    #else
    public abstract partial class References36Choice_
    #endif
    {
    }
}
