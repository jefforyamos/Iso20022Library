﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Purpose3Choice.  ISO2002 ID# _J8-MUSUOEeOgKIHGINc2Uw.
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
    /// Choice of formats for a settlement purpose.
    /// </summary>
    [KnownType(typeof(Purpose3Choice.SecuritiesPurposeCode))]
    [KnownType(typeof(Purpose3Choice.Proprietary))]
    [IsoId("_J8-MUSUOEeOgKIHGINc2Uw")]
    [DisplayName("Purpose 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Purpose3Choice_
    #else
    public abstract partial class Purpose3Choice_
    #endif
    {
    }
}
