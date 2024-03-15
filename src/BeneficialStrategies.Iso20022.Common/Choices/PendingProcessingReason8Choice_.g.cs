﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingProcessingReason8Choice.  ISO2002 ID# _OoypvljsEeOnqqBHs8Gasw.
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
    /// Choice of formats for the reason of a pending status.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason8Choice.Code))]
    [KnownType(typeof(PendingProcessingReason8Choice.Proprietary))]
    [IsoId("_OoypvljsEeOnqqBHs8Gasw")]
    [DisplayName("Pending Processing Reason 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessingReason8Choice_
    #else
    public abstract partial class PendingProcessingReason8Choice_
    #endif
    {
    }
}
