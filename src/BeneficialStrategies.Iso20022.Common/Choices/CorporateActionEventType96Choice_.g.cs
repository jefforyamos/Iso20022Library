﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType96Choice.  ISO2002 ID# _-lkSYgVSEeqjd8n6wD9JVw.
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
    /// Choice between formats to express the corporate event type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType96Choice.Code))]
    [KnownType(typeof(CorporateActionEventType96Choice.Proprietary))]
    [IsoId("_-lkSYgVSEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Event Type 96 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType96Choice_
    #else
    public abstract partial class CorporateActionEventType96Choice_
    #endif
    {
    }
}
