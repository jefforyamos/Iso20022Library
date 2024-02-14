﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReplacementProcessingStatus8Choice.  ISO2002 ID# _m8gS4TqqEeWyoP0PbocV1Q.
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
    /// Choice of format for the replacement processing status.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus8Choice.Code))]
    [KnownType(typeof(ReplacementProcessingStatus8Choice.Proprietary))]
    [IsoId("_m8gS4TqqEeWyoP0PbocV1Q")]
    [DisplayName("Replacement Processing Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReplacementProcessingStatus8Choice_
    #else
    public abstract partial class ReplacementProcessingStatus8Choice_
    #endif
    {
    }
}
