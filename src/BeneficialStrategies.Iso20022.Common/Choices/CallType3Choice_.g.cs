﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CallType3Choice.  ISO2002 ID# _fBEo0eLcEeWFtOV72FbX9w.
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
    /// Choice of format for call type.
    /// </summary>
    [KnownType(typeof(CallType3Choice.Code))]
    [KnownType(typeof(CallType3Choice.Proprietary))]
    [IsoId("_fBEo0eLcEeWFtOV72FbX9w")]
    [DisplayName("Call Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CallType3Choice_
    #else
    public abstract partial class CallType3Choice_
    #endif
    {
    }
}
