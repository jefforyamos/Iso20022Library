﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus53Choice.  ISO2002 ID# _kov6k5wsEeazcsnODTksnQ.
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
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus53Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus53Choice.Reason))]
    [IsoId("_kov6k5wsEeazcsnODTksnQ")]
    [DisplayName("Pending Status 53 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus53Choice_
    #else
    public abstract partial class PendingStatus53Choice_
    #endif
    {
    }
}
