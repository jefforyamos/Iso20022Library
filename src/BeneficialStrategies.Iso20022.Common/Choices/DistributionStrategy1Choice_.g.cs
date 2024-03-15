﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DistributionStrategy1Choice.  ISO2002 ID# _1jAiQDcgEeidBoT_PugKiA.
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
    /// Choice of formats for the specification of a distribution strategy.
    /// </summary>
    [KnownType(typeof(DistributionStrategy1Choice.Code))]
    [KnownType(typeof(DistributionStrategy1Choice.Proprietary))]
    [IsoId("_1jAiQDcgEeidBoT_PugKiA")]
    [DisplayName("Distribution Strategy 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionStrategy1Choice_
    #else
    public abstract partial class DistributionStrategy1Choice_
    #endif
    {
    }
}
