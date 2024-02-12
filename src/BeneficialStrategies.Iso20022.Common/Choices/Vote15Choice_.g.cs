﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Vote15Choice.  ISO2002 ID# _9DJBZ_NXEeqRfth943bvEA.
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
    /// Choice between a vote per agenda resolution and vote for all agenda resolutions.
    /// </summary>
    [KnownType(typeof(Vote15Choice.VotePerAgendaResolution))]
    [KnownType(typeof(Vote15Choice.VoteForAllAgendaResolutions))]
    [IsoId("_9DJBZ_NXEeqRfth943bvEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Vote 15 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Vote15Choice_
    #else
    public abstract partial class Vote15Choice_
    #endif
    {
    }
}
