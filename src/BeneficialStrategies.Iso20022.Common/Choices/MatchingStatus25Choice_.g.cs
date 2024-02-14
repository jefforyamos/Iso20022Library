﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus25Choice.  ISO2002 ID# _0XRhsTp4EeWVrPy0StzzSg.
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
    [KnownType(typeof(MatchingStatus25Choice.Matched))]
    [KnownType(typeof(MatchingStatus25Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus25Choice.Proprietary))]
    [IsoId("_0XRhsTp4EeWVrPy0StzzSg")]
    [DisplayName("Matching Status 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus25Choice_
    #else
    public abstract partial class MatchingStatus25Choice_
    #endif
    {
    }
}
