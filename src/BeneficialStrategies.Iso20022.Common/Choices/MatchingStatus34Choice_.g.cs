﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus34Choice.  ISO2002 ID# _yZ5IBxUHEeuZw7VHHgrHLg.
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
    [KnownType(typeof(MatchingStatus34Choice.Matched))]
    [KnownType(typeof(MatchingStatus34Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus34Choice.Proprietary))]
    [IsoId("_yZ5IBxUHEeuZw7VHHgrHLg")]
    [DisplayName("Matching Status 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus34Choice_
    #else
    public abstract partial class MatchingStatus34Choice_
    #endif
    {
    }
}
