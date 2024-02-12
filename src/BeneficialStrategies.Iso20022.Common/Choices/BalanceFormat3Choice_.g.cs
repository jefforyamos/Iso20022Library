﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BalanceFormat3Choice.  ISO2002 ID# _2-A6IRFPEeKp2ZN13DI_pA.
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
    [KnownType(typeof(BalanceFormat3Choice.Balance))]
    [KnownType(typeof(BalanceFormat3Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat3Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat3Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat3Choice.PartWayPeriodUnits))]
    [IsoId("_2-A6IRFPEeKp2ZN13DI_pA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance Format 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceFormat3Choice_
    #else
    public abstract partial class BalanceFormat3Choice_
    #endif
    {
    }
}
