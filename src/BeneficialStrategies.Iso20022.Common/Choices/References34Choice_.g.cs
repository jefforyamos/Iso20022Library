﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References34Choice.  ISO2002 ID# _jvDnxu5NEeCisYr99QEiWA_1809359150.
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
    /// Choice of references.
    /// </summary>
    [KnownType(typeof(References34Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References34Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References34Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References34Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References34Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References34Choice.PoolIdentification))]
    [KnownType(typeof(References34Choice.OtherTransactionIdentification))]
    [IsoId("_jvDnxu5NEeCisYr99QEiWA_1809359150")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("References 34 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References34Choice_
    #else
    public abstract partial class References34Choice_
    #endif
    {
    }
}
