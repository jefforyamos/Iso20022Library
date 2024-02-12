﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementParties36Choice.  ISO2002 ID# _Vx2Q9yqSEeyR9JrVGfaMKw.
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
    [KnownType(typeof(SettlementParties36Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties36Choice.ReceivingSettlementParties))]
    [IsoId("_Vx2Q9yqSEeyR9JrVGfaMKw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Parties 36 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties36Choice_
    #else
    public abstract partial class SettlementParties36Choice_
    #endif
    {
    }
}
