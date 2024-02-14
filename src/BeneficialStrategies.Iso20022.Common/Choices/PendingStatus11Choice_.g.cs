﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus11Choice.  ISO2002 ID# _Qg1iEf41EeClUvPNHKL9Zw.
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
    [KnownType(typeof(PendingStatus11Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus11Choice.Reason))]
    [IsoId("_Qg1iEf41EeClUvPNHKL9Zw")]
    [DisplayName("Pending Status 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus11Choice_
    #else
    public abstract partial class PendingStatus11Choice_
    #endif
    {
    }
}
