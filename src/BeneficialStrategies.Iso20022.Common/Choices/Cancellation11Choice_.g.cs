﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Cancellation11Choice.  ISO2002 ID# _8SMzVSPvEeWQjryFgN2ITg.
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
    /// Choice between cancellation by transfer details or reference.
    /// </summary>
    [KnownType(typeof(Cancellation11Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation11Choice.CancellationByReference))]
    [IsoId("_8SMzVSPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation11Choice_
    #else
    public abstract partial class Cancellation11Choice_
    #endif
    {
    }
}
