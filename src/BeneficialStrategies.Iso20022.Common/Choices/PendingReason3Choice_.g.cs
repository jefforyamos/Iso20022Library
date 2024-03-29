﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingReason3Choice.  ISO2002 ID# _UYBuM9p-Ed-ak6NoX_4Aeg_-707074176.
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
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason3Choice.Code))]
    [KnownType(typeof(PendingReason3Choice.Proprietary))]
    [IsoId("_UYBuM9p-Ed-ak6NoX_4Aeg_-707074176")]
    [DisplayName("Pending Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason3Choice_
    #else
    public abstract partial class PendingReason3Choice_
    #endif
    {
    }
}
