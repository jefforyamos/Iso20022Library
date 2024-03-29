﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementParties4Choice.  ISO2002 ID# _Bjd9wWpSEeSgo9vJrfSF_Q.
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
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties4Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties4Choice.ReceivingSettlementParties))]
    [IsoId("_Bjd9wWpSEeSgo9vJrfSF_Q")]
    [DisplayName("Settlement Parties 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties4Choice_
    #else
    public abstract partial class SettlementParties4Choice_
    #endif
    {
    }
}
