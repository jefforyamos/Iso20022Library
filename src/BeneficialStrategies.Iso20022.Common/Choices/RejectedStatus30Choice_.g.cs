﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedStatus30Choice.  ISO2002 ID# _AGV-ebKaEemux5trsZcCpw.
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
    /// Choice between a reason and no reason for the general meeting instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus30Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus30Choice.Reason))]
    [IsoId("_AGV-ebKaEemux5trsZcCpw")]
    [DisplayName("Rejected Status 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus30Choice_
    #else
    public abstract partial class RejectedStatus30Choice_
    #endif
    {
    }
}
