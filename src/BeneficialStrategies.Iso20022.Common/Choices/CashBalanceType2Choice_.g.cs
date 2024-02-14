﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CashBalanceType2Choice.  ISO2002 ID# _lGGbleFWEeWIA4E9cYSxxQ.
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
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(CashBalanceType2Choice.Code))]
    [KnownType(typeof(CashBalanceType2Choice.Proprietary))]
    [IsoId("_lGGbleFWEeWIA4E9cYSxxQ")]
    [DisplayName("Cash Balance Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashBalanceType2Choice_
    #else
    public abstract partial class CashBalanceType2Choice_
    #endif
    {
    }
}
