﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationReason5Choice.  ISO2002 ID# _UY7GFtp-Ed-ak6NoX_4Aeg_1435301661.
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
    [KnownType(typeof(CancellationReason5Choice.Code))]
    [KnownType(typeof(CancellationReason5Choice.Proprietary))]
    [IsoId("_UY7GFtp-Ed-ak6NoX_4Aeg_1435301661")]
    [DisplayName("Cancellation Reason 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason5Choice_
    #else
    public abstract partial class CancellationReason5Choice_
    #endif
    {
    }
}
