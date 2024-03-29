﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason4Choice.  ISO2002 ID# _UWrqaNp-Ed-ak6NoX_4Aeg_-1811454224.
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
    [KnownType(typeof(RejectionAndRepairReason4Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason4Choice.Proprietary))]
    [IsoId("_UWrqaNp-Ed-ak6NoX_4Aeg_-1811454224")]
    [DisplayName("Rejection And Repair Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason4Choice_
    #else
    public abstract partial class RejectionAndRepairReason4Choice_
    #endif
    {
    }
}
