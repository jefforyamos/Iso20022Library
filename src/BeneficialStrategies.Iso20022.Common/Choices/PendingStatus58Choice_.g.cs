﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus58Choice.  ISO2002 ID# _sjdwQeaEEemtTOaHuc_63w.
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
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus58Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus58Choice.Reason))]
    [IsoId("_sjdwQeaEEemtTOaHuc_63w")]
    [DisplayName("Pending Status 58 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus58Choice_
    #else
    public abstract partial class PendingStatus58Choice_
    #endif
    {
    }
}
