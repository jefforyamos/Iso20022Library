﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedStatus12Choice.  ISO2002 ID# _qg7OESwREeOEV5XHD-BKpw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    [KnownType(typeof(UnmatchedStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus12Choice.Reason))]
    [IsoId("_qg7OESwREeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Status 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus12Choice_
    #else
    public abstract partial class UnmatchedStatus12Choice_
    #endif
    {
    }
}
