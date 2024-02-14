﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcceptedStatus7Choice.  ISO2002 ID# _KNhIYTt6EeW638lNyHKv7A.
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
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus7Choice.Reason))]
    [IsoId("_KNhIYTt6EeW638lNyHKv7A")]
    [DisplayName("Accepted Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedStatus7Choice_
    #else
    public abstract partial class AcceptedStatus7Choice_
    #endif
    {
    }
}
