﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingReason17Choice.  ISO2002 ID# _f99yLTi8Eeydid5dcNPKvg.
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
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason17Choice.Code))]
    [KnownType(typeof(FailingReason17Choice.Proprietary))]
    [IsoId("_f99yLTi8Eeydid5dcNPKvg")]
    [DisplayName("Failing Reason 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingReason17Choice_
    #else
    public abstract partial class FailingReason17Choice_
    #endif
    {
    }
}
