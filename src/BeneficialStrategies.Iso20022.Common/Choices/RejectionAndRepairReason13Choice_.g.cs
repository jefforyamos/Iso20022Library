﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason13Choice.  ISO2002 ID# _OJVuX_4vEeClUvPNHKL9Zw.
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
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason13Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason13Choice.Proprietary))]
    [IsoId("_OJVuX_4vEeClUvPNHKL9Zw")]
    [DisplayName("Rejection And Repair Reason 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason13Choice_
    #else
    public abstract partial class RejectionAndRepairReason13Choice_
    #endif
    {
    }
}
