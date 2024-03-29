﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatusReason1Choice.  ISO2002 ID# _xW80EUzAEeafiMTDrtSnyw.
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
    /// Choice of formats for a pending status reason.
    /// </summary>
    [KnownType(typeof(PendingStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatusReason1Choice.Reason))]
    [IsoId("_xW80EUzAEeafiMTDrtSnyw")]
    [DisplayName("Pending Status Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatusReason1Choice_
    #else
    public abstract partial class PendingStatusReason1Choice_
    #endif
    {
    }
}
