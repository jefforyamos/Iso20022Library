﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus39Choice.  ISO2002 ID# _lip6ACzREeOsiuMH68so7Q.
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
    /// Provides the status of a transaction (eg, at a non-matching CSD) as far as the message sender is concerned.
    /// </summary>
    [KnownType(typeof(ProcessingStatus39Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus39Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus39Choice.Accepted))]
    [IsoId("_lip6ACzREeOsiuMH68so7Q")]
    [DisplayName("Processing Status 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus39Choice_
    #else
    public abstract partial class ProcessingStatus39Choice_
    #endif
    {
    }
}
