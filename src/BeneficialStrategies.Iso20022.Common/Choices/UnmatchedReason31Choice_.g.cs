﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedReason31Choice.  ISO2002 ID# _mfMbKRUIEeuZw7VHHgrHLg.
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
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason31Choice.Code))]
    [KnownType(typeof(UnmatchedReason31Choice.Proprietary))]
    [IsoId("_mfMbKRUIEeuZw7VHHgrHLg")]
    [DisplayName("Unmatched Reason 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedReason31Choice_
    #else
    public abstract partial class UnmatchedReason31Choice_
    #endif
    {
    }
}
