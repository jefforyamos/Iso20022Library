﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventType3Choice.  ISO2002 ID# _Q4g6Ytp-Ed-ak6NoX_4Aeg_489319317.
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
    [KnownType(typeof(CorporateActionEventType3Choice.Code))]
    [KnownType(typeof(CorporateActionEventType3Choice.Proprietary))]
    [IsoId("_Q4g6Ytp-Ed-ak6NoX_4Aeg_489319317")]
    [DisplayName("Corporate Action Event Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventType3Choice_
    #else
    public abstract partial class CorporateActionEventType3Choice_
    #endif
    {
    }
}
