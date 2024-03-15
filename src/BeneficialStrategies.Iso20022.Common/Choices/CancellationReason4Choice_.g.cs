﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationReason4Choice.  ISO2002 ID# _UXSHVtp-Ed-ak6NoX_4Aeg_67707561.
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
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason4Choice.Code))]
    [KnownType(typeof(CancellationReason4Choice.Proprietary))]
    [IsoId("_UXSHVtp-Ed-ak6NoX_4Aeg_67707561")]
    [DisplayName("Cancellation Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason4Choice_
    #else
    public abstract partial class CancellationReason4Choice_
    #endif
    {
    }
}
