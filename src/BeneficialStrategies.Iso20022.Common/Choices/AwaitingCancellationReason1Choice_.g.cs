﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AwaitingCancellationReason1Choice.  ISO2002 ID# _A4HJN9okEeC60axPepSq7g_471897824.
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
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AwaitingCancellationReason1Choice.Code))]
    [KnownType(typeof(AwaitingCancellationReason1Choice.Proprietary))]
    [IsoId("_A4HJN9okEeC60axPepSq7g_471897824")]
    [DisplayName("Awaiting Cancellation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AwaitingCancellationReason1Choice_
    #else
    public abstract partial class AwaitingCancellationReason1Choice_
    #endif
    {
    }
}
