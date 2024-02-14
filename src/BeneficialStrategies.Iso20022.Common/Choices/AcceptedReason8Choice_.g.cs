﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcceptedReason8Choice.  ISO2002 ID# _UUFf8VjpEeOnqqBHs8Gasw.
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
    /// Choice of formats for the reason of an accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason8Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedReason8Choice.Reason))]
    [IsoId("_UUFf8VjpEeOnqqBHs8Gasw")]
    [DisplayName("Accepted Reason 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedReason8Choice_
    #else
    public abstract partial class AcceptedReason8Choice_
    #endif
    {
    }
}
