﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingSystemReference1Choice.  ISO2002 ID# _i-a184ufEeKYr_965Eh8aQ.
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
    /// Choice between a matching system unique identification or the related reference.
    /// </summary>
    [KnownType(typeof(MatchingSystemReference1Choice.MatchingSystemUniqueReference))]
    [KnownType(typeof(MatchingSystemReference1Choice.RelatedReference))]
    [IsoId("_i-a184ufEeKYr_965Eh8aQ")]
    [DisplayName("Matching System Reference 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingSystemReference1Choice_
    #else
    public abstract partial class MatchingSystemReference1Choice_
    #endif
    {
    }
}
