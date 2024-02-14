﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionAndRepairReason38Choice.  ISO2002 ID# _ET1FcytXEeyhipY4f42fZQ.
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
    [KnownType(typeof(RejectionAndRepairReason38Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason38Choice.Proprietary))]
    [IsoId("_ET1FcytXEeyhipY4f42fZQ")]
    [DisplayName("Rejection And Repair Reason 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionAndRepairReason38Choice_
    #else
    public abstract partial class RejectionAndRepairReason38Choice_
    #endif
    {
    }
}
