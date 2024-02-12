﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MemberIdentification3Choice.  ISO2002 ID# _h_8rhXSbEeiH1ZOt2UD8vQ.
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
    /// Set of elements used to identify a financial institution.
    /// </summary>
    [KnownType(typeof(MemberIdentification3Choice.BICFI))]
    [KnownType(typeof(MemberIdentification3Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(MemberIdentification3Choice.Other))]
    [IsoId("_h_8rhXSbEeiH1ZOt2UD8vQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Member Identification 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberIdentification3Choice_
    #else
    public abstract partial class MemberIdentification3Choice_
    #endif
    {
    }
}
