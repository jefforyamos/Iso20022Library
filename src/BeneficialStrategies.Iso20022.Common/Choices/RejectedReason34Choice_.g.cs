﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedReason34Choice.  ISO2002 ID# _cFKuE-6BEeqc-LCjwLsUVg.
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
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason34Choice.Code))]
    [KnownType(typeof(RejectedReason34Choice.Proprietary))]
    [IsoId("_cFKuE-6BEeqc-LCjwLsUVg")]
    [DisplayName("Rejected Reason 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason34Choice_
    #else
    public abstract partial class RejectedReason34Choice_
    #endif
    {
    }
}
