﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus33Choice.  ISO2002 ID# _7lZ_IOB9Eei2UYJ62ws-Fw.
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
    /// Provides the matching status of the instruction.
    /// </summary>
    [KnownType(typeof(MatchingStatus33Choice.Matched))]
    [KnownType(typeof(MatchingStatus33Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus33Choice.Proprietary))]
    [IsoId("_7lZ_IOB9Eei2UYJ62ws-Fw")]
    [DisplayName("Matching Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus33Choice_
    #else
    public abstract partial class MatchingStatus33Choice_
    #endif
    {
    }
}
