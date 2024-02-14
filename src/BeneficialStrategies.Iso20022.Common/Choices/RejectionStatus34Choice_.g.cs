﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionStatus34Choice.  ISO2002 ID# _T_zx8RIwEeydmIVkS03esw.
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
    /// Instruction has been rejected for further processing.
    /// </summary>
    [KnownType(typeof(RejectionStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus34Choice.Reason))]
    [IsoId("_T_zx8RIwEeydmIVkS03esw")]
    [DisplayName("Rejection Status 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionStatus34Choice_
    #else
    public abstract partial class RejectionStatus34Choice_
    #endif
    {
    }
}
