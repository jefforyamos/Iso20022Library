﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RevaluationIndicator3Choice.  ISO2002 ID# _BveJgTw0EeW3QqUkIQtIUA.
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
    /// Choice of format for the revaluation.
    /// </summary>
    [KnownType(typeof(RevaluationIndicator3Choice.Indicator))]
    [KnownType(typeof(RevaluationIndicator3Choice.Proprietary))]
    [IsoId("_BveJgTw0EeW3QqUkIQtIUA")]
    [DisplayName("Revaluation Indicator 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RevaluationIndicator3Choice_
    #else
    public abstract partial class RevaluationIndicator3Choice_
    #endif
    {
    }
}
