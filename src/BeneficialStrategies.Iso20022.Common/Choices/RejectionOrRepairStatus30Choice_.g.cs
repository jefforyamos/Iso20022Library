﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionOrRepairStatus30Choice.  ISO2002 ID# _U2V2YTq4EeWyoP0PbocV1Q.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus30Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus30Choice.Reason))]
    [IsoId("_U2V2YTq4EeWyoP0PbocV1Q")]
    [DisplayName("Rejection Or Repair Status 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionOrRepairStatus30Choice_
    #else
    public abstract partial class RejectionOrRepairStatus30Choice_
    #endif
    {
    }
}
