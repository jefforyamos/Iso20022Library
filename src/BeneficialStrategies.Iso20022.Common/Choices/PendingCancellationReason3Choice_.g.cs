﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingCancellationReason3Choice.  ISO2002 ID# _MinedUGXEeWqy4niLuXETA.
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
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason3Choice.Code))]
    [KnownType(typeof(PendingCancellationReason3Choice.Proprietary))]
    [IsoId("_MinedUGXEeWqy4niLuXETA")]
    [DisplayName("Pending Cancellation Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationReason3Choice_
    #else
    public abstract partial class PendingCancellationReason3Choice_
    #endif
    {
    }
}
