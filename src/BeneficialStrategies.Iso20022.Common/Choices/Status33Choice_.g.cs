﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status33Choice.  ISO2002 ID# _waWF8yAeEeuyDZ-ukt4YRg.
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
    [KnownType(typeof(Status33Choice.Proprietary))]
    [KnownType(typeof(Status33Choice.MatchingStatus))]
    [KnownType(typeof(Status33Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status33Choice.SettlementStatus))]
    [KnownType(typeof(Status33Choice.InstructionProcessingStatus))]
    [IsoId("_waWF8yAeEeuyDZ-ukt4YRg")]
    [DisplayName("Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status33Choice_
    #else
    public abstract partial class Status33Choice_
    #endif
    {
    }
}
