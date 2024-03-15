﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason33Choice.  ISO2002 ID# _cPB4AeF8EeWCAvUNsZ5u6g.
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
    [KnownType(typeof(RejectionAndRepairReason33Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason33Choice.Proprietary))]
    [IsoId("_cPB4AeF8EeWCAvUNsZ5u6g")]
    [DisplayName("Rejection And Repair Reason 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason33Choice_
    #else
    public abstract partial class RejectionAndRepairReason33Choice_
    #endif
    {
    }
}
