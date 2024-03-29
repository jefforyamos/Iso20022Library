﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus19Choice.  ISO2002 ID# _ZlY6ASwREeOEV5XHD-BKpw.
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
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus19Choice.Matched))]
    [KnownType(typeof(MatchingStatus19Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus19Choice.Proprietary))]
    [IsoId("_ZlY6ASwREeOEV5XHD-BKpw")]
    [DisplayName("Matching Status 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus19Choice_
    #else
    public abstract partial class MatchingStatus19Choice_
    #endif
    {
    }
}
