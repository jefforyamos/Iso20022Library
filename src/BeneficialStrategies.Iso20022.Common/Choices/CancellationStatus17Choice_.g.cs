﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationStatus17Choice.  ISO2002 ID# _5SFnM5NLEeWGlc8L7oPDIg.
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
    [KnownType(typeof(CancellationStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus17Choice.Reason))]
    [IsoId("_5SFnM5NLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation Status 17 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationStatus17Choice_
    #else
    public abstract partial class CancellationStatus17Choice_
    #endif
    {
    }
}
