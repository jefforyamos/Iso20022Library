﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status8Choice.  ISO2002 ID# _w2B7YUABEeCaq78Ig8ATcA.
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
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status8Choice.AffirmationStatus))]
    [KnownType(typeof(Status8Choice.AllocationStatus))]
    [KnownType(typeof(Status8Choice.RepoCallRequestStatus))]
    [KnownType(typeof(Status8Choice.CorporateActionEventProcessingStatus))]
    [KnownType(typeof(Status8Choice.CorporateActionEventStage))]
    [KnownType(typeof(Status8Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status8Choice.InstructionProcessingStatus))]
    [KnownType(typeof(Status8Choice.MatchingStatus))]
    [KnownType(typeof(Status8Choice.RegistrationProcessingStatus))]
    [KnownType(typeof(Status8Choice.ResponseStatus))]
    [KnownType(typeof(Status8Choice.ReplacementProcessingStatus))]
    [KnownType(typeof(Status8Choice.CancellationProcessingStatus))]
    [KnownType(typeof(Status8Choice.SettlementStatus))]
    [KnownType(typeof(Status8Choice.SettlementConditionModificationStatus))]
    [IsoId("_w2B7YUABEeCaq78Ig8ATcA")]
    [DisplayName("Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status8Choice_
    #else
    public abstract partial class Status8Choice_
    #endif
    {
    }
}
