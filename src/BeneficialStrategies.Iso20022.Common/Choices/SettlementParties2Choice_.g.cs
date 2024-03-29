﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementParties2Choice.  ISO2002 ID# _-an2laMOEeCojJW5vEuTEQ_-1750301164.
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
    [KnownType(typeof(SettlementParties2Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties2Choice.ReceivingSettlementParties))]
    [IsoId("_-an2laMOEeCojJW5vEuTEQ_-1750301164")]
    [DisplayName("Settlement Parties 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties2Choice_
    #else
    public abstract partial class SettlementParties2Choice_
    #endif
    {
    }
}
