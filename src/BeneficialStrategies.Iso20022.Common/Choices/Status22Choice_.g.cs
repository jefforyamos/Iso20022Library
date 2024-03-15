﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status22Choice.  ISO2002 ID# _8QboH5NLEeWGlc8L7oPDIg.
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
    [KnownType(typeof(Status22Choice.AffirmationStatus))]
    [KnownType(typeof(Status22Choice.AllocationStatus))]
    [KnownType(typeof(Status22Choice.RepoCallRequestStatus))]
    [KnownType(typeof(Status22Choice.CorporateActionEventProcessingStatus))]
    [KnownType(typeof(Status22Choice.CorporateActionEventStage))]
    [KnownType(typeof(Status22Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status22Choice.InstructionProcessingStatus))]
    [KnownType(typeof(Status22Choice.MatchingStatus))]
    [KnownType(typeof(Status22Choice.RegistrationProcessingStatus))]
    [KnownType(typeof(Status22Choice.ResponseStatus))]
    [KnownType(typeof(Status22Choice.ReplacementProcessingStatus))]
    [KnownType(typeof(Status22Choice.CancellationProcessingStatus))]
    [KnownType(typeof(Status22Choice.SettlementStatus))]
    [KnownType(typeof(Status22Choice.SettlementConditionModificationStatus))]
    [IsoId("_8QboH5NLEeWGlc8L7oPDIg")]
    [DisplayName("Status 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status22Choice_
    #else
    public abstract partial class Status22Choice_
    #endif
    {
    }
}
