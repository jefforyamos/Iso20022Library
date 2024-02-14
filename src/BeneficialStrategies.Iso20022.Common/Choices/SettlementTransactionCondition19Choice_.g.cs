﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementTransactionCondition19Choice.  ISO2002 ID# _GNYdQTxKEeW5v6FXICU4Ew.
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
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition19Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition19Choice.Proprietary))]
    [IsoId("_GNYdQTxKEeW5v6FXICU4Ew")]
    [DisplayName("Settlement Transaction Condition 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTransactionCondition19Choice_
    #else
    public abstract partial class SettlementTransactionCondition19Choice_
    #endif
    {
    }
}
