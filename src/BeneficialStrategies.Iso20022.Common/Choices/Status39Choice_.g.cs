﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status39Choice.  ISO2002 ID# _gEIFaji8Eeydid5dcNPKvg.
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
    /// Choice between statuses.
    /// </summary>
    [KnownType(typeof(Status39Choice.Proprietary))]
    [KnownType(typeof(Status39Choice.MatchingStatus))]
    [KnownType(typeof(Status39Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status39Choice.SettlementStatus))]
    [KnownType(typeof(Status39Choice.InstructionProcessingStatus))]
    [IsoId("_gEIFaji8Eeydid5dcNPKvg")]
    [DisplayName("Status 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status39Choice_
    #else
    public abstract partial class Status39Choice_
    #endif
    {
    }
}
