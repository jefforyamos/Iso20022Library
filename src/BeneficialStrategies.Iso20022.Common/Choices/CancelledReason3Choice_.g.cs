﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledReason3Choice.  ISO2002 ID# _YlglkeJxEd-Q6MzBzY5WkA.
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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason3Choice.Code))]
    [KnownType(typeof(CancelledReason3Choice.Proprietary))]
    [IsoId("_YlglkeJxEd-Q6MzBzY5WkA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancelled Reason 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledReason3Choice_
    #else
    public abstract partial class CancelledReason3Choice_
    #endif
    {
    }
}
