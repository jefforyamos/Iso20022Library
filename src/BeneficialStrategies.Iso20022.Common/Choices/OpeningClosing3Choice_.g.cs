﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OpeningClosing3Choice.  ISO2002 ID# _gj_VkTtCEeWRTLSN0i0tng.
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
    /// Choice of format for the opening closing information.
    /// </summary>
    [KnownType(typeof(OpeningClosing3Choice.Code))]
    [KnownType(typeof(OpeningClosing3Choice.Proprietary))]
    [IsoId("_gj_VkTtCEeWRTLSN0i0tng")]
    [DisplayName("Opening Closing 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OpeningClosing3Choice_
    #else
    public abstract partial class OpeningClosing3Choice_
    #endif
    {
    }
}
