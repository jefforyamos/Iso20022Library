﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus20Choice.  ISO2002 ID# _0k3gwglIEeGATtfOBToyew_-1102038135.
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
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(PendingStatus20Choice.Forwarded))]
    [KnownType(typeof(PendingStatus20Choice.UnderInvestigation))]
    [IsoId("_0k3gwglIEeGATtfOBToyew_-1102038135")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pending Status 20 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus20Choice_
    #else
    public abstract partial class PendingStatus20Choice_
    #endif
    {
    }
}
