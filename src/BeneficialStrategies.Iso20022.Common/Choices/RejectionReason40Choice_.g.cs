﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason40Choice.  ISO2002 ID# _Uq4INRIwEeydmIVkS03esw.
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
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [KnownType(typeof(RejectionReason40Choice.Code))]
    [KnownType(typeof(RejectionReason40Choice.Proprietary))]
    [IsoId("_Uq4INRIwEeydmIVkS03esw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejection Reason 40 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason40Choice_
    #else
    public abstract partial class RejectionReason40Choice_
    #endif
    {
    }
}
