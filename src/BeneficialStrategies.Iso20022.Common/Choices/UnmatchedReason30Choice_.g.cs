﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedReason30Choice.  ISO2002 ID# _4-yjYOCXEei2UYJ62ws-Fw.
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
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [KnownType(typeof(UnmatchedReason30Choice.Code))]
    [KnownType(typeof(UnmatchedReason30Choice.Proprietary))]
    [IsoId("_4-yjYOCXEei2UYJ62ws-Fw")]
    [DisplayName("Unmatched Reason 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason30Choice_
    #else
    public abstract partial class UnmatchedReason30Choice_
    #endif
    {
    }
}
