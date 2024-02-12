﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References19Choice.  ISO2002 ID# _w7exzUADEeC4mKrqv7wPJQ.
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
    [KnownType(typeof(References19Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References19Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References19Choice.PoolIdentification))]
    [KnownType(typeof(References19Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References19Choice.ProcessorTransactionIdentification))]
    [IsoId("_w7exzUADEeC4mKrqv7wPJQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("References 19 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References19Choice_
    #else
    public abstract partial class References19Choice_
    #endif
    {
    }
}
