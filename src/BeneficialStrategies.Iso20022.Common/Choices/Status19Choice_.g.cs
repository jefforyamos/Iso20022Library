﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status19Choice.  ISO2002 ID# _8nU2ETqpEeWyoP0PbocV1Q.
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
    [KnownType(typeof(Status19Choice.AffirmationStatus))]
    [KnownType(typeof(Status19Choice.AllocationStatus))]
    [KnownType(typeof(Status19Choice.RepoCallRequestStatus))]
    [KnownType(typeof(Status19Choice.CorporateActionEventProcessingStatus))]
    [KnownType(typeof(Status19Choice.CorporateActionEventStage))]
    [KnownType(typeof(Status19Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status19Choice.InstructionProcessingStatus))]
    [KnownType(typeof(Status19Choice.MatchingStatus))]
    [KnownType(typeof(Status19Choice.RegistrationProcessingStatus))]
    [KnownType(typeof(Status19Choice.ResponseStatus))]
    [KnownType(typeof(Status19Choice.ReplacementProcessingStatus))]
    [KnownType(typeof(Status19Choice.CancellationProcessingStatus))]
    [KnownType(typeof(Status19Choice.SettlementStatus))]
    [KnownType(typeof(Status19Choice.SettlementConditionModificationStatus))]
    [IsoId("_8nU2ETqpEeWyoP0PbocV1Q")]
    [DisplayName("Status 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status19Choice_
    #else
    public abstract partial class Status19Choice_
    #endif
    {
    }
}
