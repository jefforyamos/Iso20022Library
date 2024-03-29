﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionUnallocatedBalanceSD3Choice.  ISO2002 ID# _uTU8wcSTEeeRJJtE9TSlkw.
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
    /// Choice amongst various balance types related to unallocated payment.
    /// </summary>
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.TotalEligibleBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.BorrowedBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.CollateralInBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.CollateralOutBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.OnLoanBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.PendingDeliveryBalance))]
    [KnownType(typeof(CorporateActionUnallocatedBalanceSD3Choice.PendingReceiptBalance))]
    [IsoId("_uTU8wcSTEeeRJJtE9TSlkw")]
    [DisplayName("Corporate Action Unallocated Balance SD 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionUnallocatedBalanceSD3Choice_
    #else
    public abstract partial class CorporateActionUnallocatedBalanceSD3Choice_
    #endif
    {
    }
}
