﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementParties3Choice.  ISO2002 ID# __eyMsWQQEeSTN56gbbyx2g.
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
    [KnownType(typeof(SettlementParties3Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties3Choice.ReceivingSettlementParties))]
    [IsoId("__eyMsWQQEeSTN56gbbyx2g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Parties 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties3Choice_
    #else
    public abstract partial class SettlementParties3Choice_
    #endif
    {
    }
}
