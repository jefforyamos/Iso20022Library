﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus7Choice.  ISO2002 ID# _GJDy8f5WEeCtrO5qCU90cA.
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
    [KnownType(typeof(MatchingStatus7Choice.Matched))]
    [KnownType(typeof(MatchingStatus7Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus7Choice.Proprietary))]
    [IsoId("_GJDy8f5WEeCtrO5qCU90cA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Matching Status 7 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus7Choice_
    #else
    public abstract partial class MatchingStatus7Choice_
    #endif
    {
    }
}
