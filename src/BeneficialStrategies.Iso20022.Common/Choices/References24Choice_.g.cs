﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References24Choice.  ISO2002 ID# _H-S65_7uEeCvPoRGOxRobQ.
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
    [KnownType(typeof(References24Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References24Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References24Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References24Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References24Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References24Choice.PoolIdentification))]
    [KnownType(typeof(References24Choice.CommonIdentification))]
    [KnownType(typeof(References24Choice.TradeIdentification))]
    [KnownType(typeof(References24Choice.OtherTransactionIdentification))]
    [IsoId("_H-S65_7uEeCvPoRGOxRobQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("References 24 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References24Choice_
    #else
    public abstract partial class References24Choice_
    #endif
    {
    }
}
