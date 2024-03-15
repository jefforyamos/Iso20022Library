﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedStatus16Choice.  ISO2002 ID# _Hq3ssTqOEeWyoP0PbocV1Q.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus16Choice.Reason))]
    [IsoId("_Hq3ssTqOEeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Status 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnmatchedStatus16Choice_
    #else
    public abstract partial class UnmatchedStatus16Choice_
    #endif
    {
    }
}
