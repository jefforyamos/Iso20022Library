﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementDate19Choice.  ISO2002 ID# _qq8vIbPwEeelzbgsFa3sqQ.
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
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate19Choice.Date))]
    [KnownType(typeof(SettlementDate19Choice.DateCode))]
    [IsoId("_qq8vIbPwEeelzbgsFa3sqQ")]
    [DisplayName("Settlement Date 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate19Choice_
    #else
    public abstract partial class SettlementDate19Choice_
    #endif
    {
    }
}
