﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceFormat12Choice.  ISO2002 ID# _KADDNRuyEeyhRdHRjakS2w.
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
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat12Choice.Balance))]
    [KnownType(typeof(BalanceFormat12Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat12Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat12Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat12Choice.PartWayPeriodUnits))]
    [IsoId("_KADDNRuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Format 12 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat12Choice_
    #else
    public abstract partial class BalanceFormat12Choice_
    #endif
    {
    }
}
